using System;
using Api.Dominio.ValorObjeto;

namespace Api.Dominio.Entidade
{
    public class PagamentoPayPal : Pagamento
    {
        // => a base é para pegar a referencia da classe pai, pois como a mesma é abstrata não pode ser referenciada
        public PagamentoPayPal(string codigoDaTransicao, string numero, DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPagamento, Endereco endereco, Documento documento, string propretario, Email email) 
            : base (numero, dataPagamento, dataExpiracao, total, totalPagamento, endereco, documento, propretario, email)
        {
            CodigoDaTransicao = codigoDaTransicao;
        }
        // => Tipo primitivo para pegar o código da transação do paypal
        public string CodigoDaTransicao { get; private set; }
    }
}