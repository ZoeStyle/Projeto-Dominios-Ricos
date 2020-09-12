using Api.Dominio.Entidade;
using Api.Dominio.Enumerados;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Testes.ValoresObjeto
{
    [TestClass]
    public class AlunoTeste
    {
        // Metodologia de teste
        // => Red, green, refactor
        // => primeiramente você faça o teste que apresente todos os dados incorretamente
        // => depois que todas validações deem certo
        // => depois refatora o código
        [TestMethod]
        [DataTestMethod]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        public void CnpjInvalido(string cnpj)
        {
            var doc = new Documento(cnpj, ETipoDocumentos.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("06566196000162")]
        [DataRow("51111253000173")]
        [DataRow("73640315000177")]
        [DataRow("18911030000115")]
        [DataRow("31140495000188")]
        [DataRow("33520106000175")]
        [DataRow("20619463000143")]
        [DataRow("85992652000102")]
        [DataRow("06635137000107")]
        [DataRow("13038065000178")]
        [DataRow("94236285000108")]
        [DataRow("54689173000198")]
        [DataRow("40754637000198")]
        [DataRow("83374768000152")]
        public void CnpjValido(string cnpj)
        {
            var doc = new Documento(cnpj, ETipoDocumentos.CNPJ);
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        [DataRow("123")]
        public void CpfInvalido(string cpf)
        {
            var doc = new Documento( cpf , ETipoDocumentos.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("24092350007")]
        [DataRow("04586722037")]
        [DataRow("73127244002")]
        [DataRow("14610075008")]
        [DataRow("33458479066")]
        [DataRow("45656946037")]
        [DataRow("03645884033")]
        [DataRow("52387010043")]
        [DataRow("05385660000")]
        [DataRow("22398242048")]
        [DataRow("70188905006")]
        [DataRow("04004845017")]
        [DataRow("10907307051")]
        [DataRow("09485821034")]
        [DataRow("49702660009")]
        [DataRow("33021891098")]
        public void CpfValido(string cpf)
        {
            var doc = new Documento(cpf, ETipoDocumentos.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}
