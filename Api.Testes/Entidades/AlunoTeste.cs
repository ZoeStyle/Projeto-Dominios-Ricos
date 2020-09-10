using Api.Dominio.Entidade;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Testes.Entidades
{
    [TestClass]
    public class AlunoTeste
    {
        [TestMethod]
        public void TestMethod1()
        {
            var assinatura = new Assinatura(null);
            var aluno = new Aluno("Victor","Santos","42463930888","regiotimao@gmail.com");
            aluno.AdicionarAssinatura(assinatura);
        }
    }
}
