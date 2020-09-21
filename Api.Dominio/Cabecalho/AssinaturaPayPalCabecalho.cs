using System;
using Api.Compartilhamento.Cabecalhos;
using Api.Compartilhamento.Comandos;
using Api.Dominio.Comando;
using Api.Dominio.Entidade;
using Api.Dominio.Enumerados;
using Api.Dominio.Repositorio;
using Api.Dominio.Servicos;
using Api.Dominio.ValorObjeto;
using Flunt.Notifications;

namespace Api.Dominio.Cabecalho
{
    public class AssinaturaPaypalCabecalho :
    Notifiable,
    ICabecalhos<ComandoCriarAssinaturaPayPal>
    {
        private readonly IAlunoRepositorio _alunoRepositorio;
        private readonly IServicoEmail _servicoEmail;

        public AssinaturaPaypalCabecalho(IAlunoRepositorio alunorepositorio, IServicoEmail servicoEmail)
        {
            _alunoRepositorio = alunorepositorio;
            _servicoEmail = servicoEmail;
        }

        public IResultadoComando Cabecalho(ComandoCriarAssinaturaPayPal comando)
        {
            #region Verifica falhas nas validações
            comando.Validate();
            if (comando.Invalid)
            {
                AddNotifications(comando);
                return new ResultadoComando(false, "Não foi possivel realizar seu cadastro");
            }
            #endregion

            #region Verifica se o CPF já esta cadastrado
            if (_alunoRepositorio.ExisteDocumento(comando.Documento))
                AddNotification("Documento", "O C`F já esta em uso!");
            #endregion

            #region Verificar se o Email ja esta cadastrado
            if (_alunoRepositorio.ExisteEmail(comando.Email))
                AddNotification("Email", "O email já esta em uso!");
            #endregion

            #region Gerar os VOs
            var nome = new Nome(comando.PrimeiroNome, comando.UltimoNome);
            var documento = new Documento(comando.Documento, ETipoDocumentos.CPF);
            var email = new Email(comando.Email);
            var endereco = new Endereco(
                    comando.Rua,
                    comando.Numero,
                    comando.Complemento,
                    comando.Bairro,
                    comando.Cidade,
                    comando.Estado,
                    comando.CEP
                    );
            #endregion

            #region Gerar as Entidades
            var aluno = new Aluno(nome, documento, email);
            var assinatura = new Assinatura(DateTime.Now.AddMonths(1));
            var pagamento = new PagamentoPayPal(
                comando.CodigoDaTransicao,
                comando.DataPagamento,
                comando.DataExpiracao,
                comando.Total,
                comando.TotalPagamento,
                endereco,
                documento,
                comando.NomePropretario,
                email
            );
            #endregion

            #region Relacionamento
            assinatura.AdicionarPagamento(pagamento);
            aluno.AdicionarAssinatura(assinatura);
            #endregion

            #region Agrupar as validações
            AddNotifications(nome, documento, email, endereco, aluno, assinatura, email);
            #endregion

            #region Salvar as informações
            _alunoRepositorio.CriarAssinatura(aluno);
            #endregion

            #region Enviar o email de boas vindas
            _servicoEmail.Enviar(
                aluno.Nome.ToString(),
                aluno.Email.Emdereco,
                "Bem vindo a nosso site!",
                "Sua assinatura foi criada com successo"
                );
            #endregion

            #region Retornar informações
            return new ResultadoComando(true, "Assinatura realizada com sucesso");
            #endregion
        }
    }
}