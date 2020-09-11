using System;
using Api.Compartilhamento.Entidades;
using Api.Dominio.ValorObjeto;

namespace Api.Dominio.Entidade
{
    public abstract class Pagamento : Entidades
    {
        protected Pagamento(string numero, DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPagamento, Endereco endereco, Documento documento, string propretario, Email email)
        {
            // => O guid gera um código transforma em string => toString() => 
            // => retira os tracinhos => Replace("primeiro parametro que deseja retirar", "segundo parametro que ira entrar")
            // => pega as 10 primeiras posições => SubString(0,10)
            // => transforma tudo em maiusculo 
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            DataPagamento = dataPagamento;
            DataExpiracao = dataExpiracao;
            Total = total;
            TotalPagamento = totalPagamento;
            Endereco = endereco;
            Documento = documento;
            Propretario = propretario;
            Email = email;
        }
        // => Tipo primitivo que gera o numero da transação do pagamento
        public string Numero { get; private set; }
        // => Tipo primitivo que registra a data do pagamento
        public DateTime DataPagamento { get; private set; }
        // => Tipo primitivo que registra a data de expiração do pagamento
        public DateTime DataExpiracao { get; private set; }
        // => Tipo primitivo que registra o valor total do pago
        public decimal Total { get; private set; }
        // => Tipo primitivo que registra o valor total do pagamento
        public decimal TotalPagamento { get; private set; }
        // => Este método vc informa todos os campos para o endereco (Rua, numero,Complemento, Cidade, Bairro,Estado,CEP)
        public Endereco Endereco { get; private set; }
        // => Este metodo voce informa o numero do documento e o tipo de documento cpf e cnpj
        public Documento Documento { get; private set; }
        // => Tipo primitivo que adiciona os dados do proprietario do pagamento
        public string Propretario { get; private set; }
        // => Este metodo você informa o  endereco de email
        public Email Email { get; private set; }

    }
}