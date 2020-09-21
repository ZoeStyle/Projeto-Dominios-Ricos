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
    public class AssinaturaBoletoCabecalho :
    Notifiable, 
    ICabecalhos<ComandoCriarAssinaturaBoleto>
    {
        private readonly IAlunoRepositorio _repositorio;
        private readonly IServicoEmail _emailRepositorio;

        public AssinaturaBoletoCabecalho(IAlunoRepositorio repositorio, IServicoEmail emailRepositorio)
        {
            _repositorio = repositorio;
            _emailRepositorio = emailRepositorio;
        }
        public IResultadoComando Cabecalho(ComandoCriarAssinaturaBoleto comando)
        {
            #region Verifica falhas nas validações
            comando.Validate();
            if (comando.Invalid)
            {
                AddNotifications(comando);
                return new ResultadoComando(false, "Não foi possivel realizar seu cadastro");
            }
            #endregion

            #region Verifica se o documento já esta cadastrado
            if (_repositorio.ExisteDocumento(comando.Documento))
                AddNotification("Documento", "Este CPF já existe em uso");
            #endregion

            #region Verificar se o Email ja esta cadastrado
            if (_repositorio.ExisteEmail(comando.Email))
                AddNotification("Email", "Este Email já existe em uso");
            #endregion

            #region Gerar os VOs
            var nome = new Nome(comando.PrimeiroNome, comando.UltimoNome);
            var documento = new Documento(comando.Documento, ETipoDocumentos.CPF);
            var email = new Email(comando.Email);
            var endereco = new Endereco(comando.Rua, comando.Numero, comando.Complemento, comando.Bairro, comando.Cidade, comando.Estado, comando.CEP);
            #endregion

            #region Gerar as Entidades
            var aluno = new Aluno(nome, documento, email);
            var assinatura = new Assinatura(DateTime.Now.AddMonths(1));
            var pagamento = new PagamentoBoleto(
                    comando.CodigoDeBarras,
                    comando.NumeroBoleto,
                    comando.DataPagamento,
                    comando.DataExpiracao,
                    comando.Total,
                    comando.TotalPagamento,
                    endereco,
                    documento,
                    comando.ProprietarioDocumento,
                    email);
            #endregion

            #region Relacionamento
            assinatura.AdicionarPagamento(pagamento);
            aluno.AdicionarAssinatura(assinatura);
            #endregion

            #region Agrupar as validações
            AddNotifications(nome, email, documento, endereco, aluno, assinatura, pagamento);
            #endregion

            #region Checar validações
            if (Invalid)
                return new ResultadoComando(false, "Não foi possivel realizar sua assinatura");
            #endregion

            #region Salvar as informações
            _repositorio.CriarAssinatura(aluno);
            #endregion

            #region Enviar o email de boas vindas
            _emailRepositorio.Enviar(
                aluno.Nome.ToString(),
                aluno.Email.Emdereco,
                "Bem vindo a nosso site!",
                "Sua assinatura foi criada com successo");
            #endregion

            #region Retornar informações
            return new ResultadoComando(true, "Assinatura realizada com sucesso");
            #endregion
        }

    }
}