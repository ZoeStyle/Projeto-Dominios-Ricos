using System;
using Api.Dominio.ValorObjeto;

namespace Api.Dominio.Entidade
{
    public class PagamentoBoleto : Pagamento
    {
        // => a base é para pegar a referencia da classe pai, pois como a mesma é abstrata não pode ser referenciada
        public PagamentoBoleto(string codigoDeBarras, string numeroBoleto, DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPagamento, Endereco endereco, Documento documento, string propretario, Email email)
            : base( dataPagamento, dataExpiracao, total, totalPagamento, endereco, documento, propretario, email)
        {
            CodigoDeBarras = codigoDeBarras;
            NumeroBoleto = numeroBoleto;
        }
        // => Tipo primitivo para pegar o código de barras
        public string CodigoDeBarras { get; private set; }
        // => Tipo primitivo para pegar o numero de boleto  
        public string NumeroBoleto { get; private set; }
    }
}