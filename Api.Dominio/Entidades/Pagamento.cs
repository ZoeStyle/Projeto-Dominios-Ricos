using System;

namespace Api.Dominio.Entidade
{
    public abstract class Pagamento
    {
        protected Pagamento(string numero, DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPagamento, string endereco, string documento, string propretario, string email)
        {
            // O guid gera um código transforma em string => toString() => 
            // retira os tracinhos => Replace("primeiro parametro que deseja retirar", "segundo parametro que ira entrar")
            // pega as 10 primeiras posições => SubString(0,10)
            // transforma tudo em maiusculo 
            Numero = Guid.NewGuid().ToString().Replace("-","").Substring(0, 10).ToUpper();
            DataPagamento = dataPagamento;
            DataExpiracao = dataExpiracao;
            Total = total;
            TotalPagamento = totalPagamento;
            Endereco = endereco;
            Documento = documento;
            Propretario = propretario;
            Email = email;
        }

        public string Numero { get; private set; }
        public DateTime DataPagamento { get; private  set; }
        public DateTime DataExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPagamento { get; private set; }
        public string Endereco { get; private set; }
        public string Documento { get; private set; }
        public string Propretario { get; private set; }
        public string Email { get; private set; }

    }
}