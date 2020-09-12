using System;
using Api.Dominio.Entidade;
using Api.Dominio.Enumerados;
using Api.Dominio.ValorObjeto;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Testes.Entidades
{
    [TestClass]
    public class AlunoTeste
    {
        private readonly Nome _nome;
        private readonly Documento _documento;
        private readonly Email _email;
        private readonly Endereco _endereco;
        private readonly Aluno _aluno;
        private Assinatura _assinatura;

        public AlunoTeste()
        {
            _nome = new Nome("Victor", "Santos");
            _documento = new Documento("42463930888", ETipoDocumentos.CPF);
            _email = new Email("victor@gmail.com");
            _endereco = new Endereco("Rua 1", "123", "aaa", "jaragua", "são paulo", "sp", "02995100");
            _aluno = new Aluno(_nome, _documento, _email);
            _assinatura = new Assinatura(null);

        }

        [TestMethod]
        public void AtivarAssinaturaInvalido()
        {
            var pagamento = new PagamentoPayPal("12345", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, _endereco, _documento, "SoftClever", _email);

            _assinatura.AdicionarPagamento(pagamento);

            _aluno.AdicionarAssinatura(_assinatura);
            _aluno.AdicionarAssinatura(_assinatura);

            Assert.IsTrue(_aluno.Invalid);
        }

        [TestMethod]
        public void AssinaturaSemPagamento()
        {
            _aluno.AdicionarAssinatura(_assinatura);

            Assert.IsTrue(_aluno.Invalid);
        }

        [TestMethod]
        public void AtivarAssinaturaValido()
        {
            var pagamento = new PagamentoPayPal("12345", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, _endereco, _documento, "SoftClever", _email);

            _assinatura.AdicionarPagamento(pagamento);

            _aluno.AdicionarAssinatura(_assinatura);
            
            Assert.IsTrue(_aluno.Valid);
        }
    }
}
