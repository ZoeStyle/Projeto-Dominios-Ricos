using System;

namespace Api.Dominio.Entidade
{
    public class PagamentoBoleto : Pagamento
    {
        public PagamentoBoleto(string codigoDeBarras, string numeroBoleto, string numero, DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPagamento, string endereco, string documento, string propretario, string email)
            : base (numero, dataPagamento, dataExpiracao, total, totalPagamento, endereco, documento, propretario, email)
        {
            CodigoDeBarras = codigoDeBarras;
            NumeroBoleto = numeroBoleto;
        }

        public string CodigoDeBarras { get; private set; }
        public string NumeroBoleto { get; private set; }
    }
}