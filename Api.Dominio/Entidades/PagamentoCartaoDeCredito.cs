using System;

namespace Api.Dominio.Entidade
{
    public class PagamentoCartaoDeCredito : Pagamento
    {
        public PagamentoCartaoDeCredito(string nomeTitular, string numeroDoCartao, string ultimaTransacao,string numero, DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPagamento, string endereco, string documento, string propretario, string email)
            : base (numero, dataPagamento, dataExpiracao, total, totalPagamento, endereco, documento, propretario, email)
        {
            NomeTitular = nomeTitular;
            NumeroDoCartao = numeroDoCartao;
            UltimaTransacao = ultimaTransacao;
        }

        public string NomeTitular { get; private set; }
        public string NumeroDoCartao { get; private set; }
        public string UltimaTransacao { get; private set; }
    }
}