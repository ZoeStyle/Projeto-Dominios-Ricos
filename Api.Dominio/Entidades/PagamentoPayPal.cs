using System;

namespace Api.Dominio.Entidade
{
    public class PagamentoPayPal : Pagamento
    {
        public PagamentoPayPal(string codigoDaTransicao, string numero, DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPagamento, string endereco, string documento, string propretario, string email) 
            : base (numero, dataPagamento, dataExpiracao, total, totalPagamento, endereco, documento, propretario, email)
        {
            CodigoDaTransicao = codigoDaTransicao;
        }

        public string CodigoDaTransicao { get; private set; }
    }
}