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
            var nome = new Nome("Teste", "Teste");
            foreach (var not in nome.Notifications)
            {
                
            }
        }
    }
}
