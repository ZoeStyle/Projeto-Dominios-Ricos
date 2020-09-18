using Api.Compartilhamento.Cabecalhos;
using Api.Compartilhamento.Comandos;
using Api.Dominio.Comando;
using Api.Dominio.Repositorio;
using Api.Dominio.Servicos;
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
                            
            #endregion

            #region Verifica se o documento já esta cadastrado
                
            #endregion

            #region Verificar se o Email ja esta cadastrado
                
            #endregion

            #region Gerar os VOs
                
            #endregion

            #region Gerar as Entidades
                
            #endregion

            #region Relacionamento
                
            #endregion

            #region Agrupar as validações
                
            #endregion

            #region Salvar as informações
                
            #endregion

            #region Enviar o email de boas vindas
                
            #endregion

            #region Retornar informações
            return new ResultadoComando(true, "Assinatura realizada com sucesso");
            #endregion
        }
    }
}