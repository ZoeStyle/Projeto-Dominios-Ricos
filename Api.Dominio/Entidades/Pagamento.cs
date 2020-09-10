using System;

namespace Api.Dominio.Entidade
{
    public abstract class Pagamento
    {
        public string Numero { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataExpiracao { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPagamento { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }
        public string Propretario { get; set; }
        public string Email { get; set; }

    }
    public class PagamentoBoleto : Pagamento
    {
        public string CodigoDeBarras { get; set; }
        public string NumeroBoleto { get; set; }
    }
    public class PagamentoCartaoDeCredito : Pagamento
    {
        public string NomeTitular { get; set; }
        public string NumeroDoCartao { get; set; }
        public string UltimaTransacao { get; set; }
    }
    public class PagamentoPayPal : Pagamento
    {
        public string CodigoDaTransicao { get; set; }       
    }
}