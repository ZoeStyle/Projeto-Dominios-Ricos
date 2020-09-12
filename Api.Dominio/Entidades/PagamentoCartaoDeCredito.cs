using System;
using Api.Dominio.ValorObjeto;

namespace Api.Dominio.Entidade
{
    public class PagamentoCartaoDeCredito : Pagamento
    {
        // => a base é para pegar a referencia da classe pai, pois como a mesma é abstrata não pode ser referenciada
        public PagamentoCartaoDeCredito(string nomeTitular, string numeroDoCartao, string ultimaTransacao, DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPagamento, Endereco endereco, Documento documento, string propretario, Email email)
            : base( dataPagamento, dataExpiracao, total, totalPagamento, endereco, documento, propretario, email)
        {
            NomeTitular = nomeTitular;
            NumeroDoCartao = numeroDoCartao;
            UltimaTransacao = ultimaTransacao;
        }
        // => Tipo primitivo para pegar o nome do titular do cartão de credito 
        public string NomeTitular { get; private set; }
        // => Tipo primitivo para registrar os ultimos quatro digitos do cartão
        public string NumeroDoCartao { get; private set; }
        // => Tipo primitivo para registrar a ultima transação 
        public string UltimaTransacao { get; private set; }
    }
}