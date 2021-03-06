using System;
using Api.Compartilhamento.Comandos;
using Api.Dominio.Enumerados;
using Flunt.Notifications;
using Flunt.Validations;

namespace Api.Dominio.Comando
{
    public class ComandoCriarAssinaturaCredito : Notifiable, IComando
    {
        #region Campos obrigatorios para criar o Aluno

        #region Nome
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        #endregion

        #region Documento (Sempre será fisica)
        public string Documento { get; set; }
        #endregion

        #region Email
        public string Email { get; set; }
        #endregion

        #endregion

        #region Criar Assinatura pagamento Crédito

        #region Dados do pagamento
        public string NomeTitular { get; set; }
        public string NumeroDoCartao { get; set; }
        public string UltimaTransacao { get; set; }
        public string NumeroPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataExpiracao { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPagamento { get; set; }
        #endregion

        #region Documento do proprietario do documento
        public string NomePropretario { get; set; }
        public string ProprietarioDocumento { get; set; }
        public ETipoDocumentos DocumentoProprietarioPagamento { get; set; }
        #endregion

        #region Endereco de cobranca do pagamento
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        #endregion

        #region Email da area de pagamento
        public string EmailPagamento { get; set; }
        #endregion

        #endregion

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(PrimeiroNome, 3, "PrimeiroNome", "O Nome deve conter no minimo 3 caracteres")
                .HasMinLen(UltimoNome, 3, "UltimoNome", "O Sobrenome deve conter no minimo 3 caracteres")
                .HasMaxLen(PrimeiroNome, 20, "PrimeiroNome", "O Nome deve conter no minimo 3 caracteres")
                .HasMaxLen(UltimoNome, 20, "PrimeiroNome", "O Sobrenome deve conter no minimo 3 caracteres")
            );
        }
    }
}