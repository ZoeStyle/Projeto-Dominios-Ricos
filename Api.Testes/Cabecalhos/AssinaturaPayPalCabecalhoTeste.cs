using System;
using Api.Dominio.Cabecalho;
using Api.Dominio.Comando;
using Api.Dominio.Enumerados;
using Api.Testes.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Testes.Cabecalhos
{
    [TestClass]
    public class AssinaturaPayPalCabecalhoTeste
    {
        private AssinaturaPaypalCabecalho _cabecalho;
        private ComandoCriarAssinaturaPayPal _comando;

        public AssinaturaPayPalCabecalhoTeste()
        {
            _cabecalho = new AssinaturaPaypalCabecalho(new FakeAlunoRepositorio(), new FakeServicoEmail());
            _comando = new ComandoCriarAssinaturaPayPal();

        }

        [TestMethod]
        public void DocumentoExistenteValido()
        {
            _comando.PrimeiroNome = "Victor";
            _comando.UltimoNome = "Santos";
            _comando.Documento = "99999999999";
            _comando.Email = "123@hernandes.com";
            _comando.CodigoDaTransicao = "1234567";
            _comando.NumeroPagamento = "123456789";
            _comando.DataPagamento = DateTime.Now;
            _comando.DataExpiracao = DateTime.Now.AddMonths(1);
            _comando.Total = 60;
            _comando.TotalPagamento = 60;
            _comando.NomePropretario = "Victor Hernandes";
            _comando.ProprietarioDocumento = "99999999999";
            _comando.DocumentoProprietarioPagamento = ETipoDocumentos.CPF;
            _comando.Rua = "teste";
            _comando.Numero = "12345";
            _comando.Complemento = "teste";
            _comando.Bairro = "teste";
            _comando.Cidade = "teste";
            _comando.Estado = "te";
            _comando.CEP = "99999999";
            _comando.EmailPagamento = "123@hernandes.com";

            _cabecalho.Cabecalho(_comando);
            Assert.AreEqual(false, _cabecalho.Valid);
        }


        [TestMethod]
        public void EmailExistenteValido()
        {
            _comando.PrimeiroNome = "Victor";
            _comando.UltimoNome = "Santos";
            _comando.Documento = "99999999998";
            _comando.Email = "hello@hernandes.com";
            _comando.CodigoDaTransicao = "1234567";
            _comando.NumeroPagamento = "123456789";
            _comando.DataPagamento = DateTime.Now;
            _comando.DataExpiracao = DateTime.Now.AddMonths(1);
            _comando.Total = 60;
            _comando.TotalPagamento = 60;
            _comando.NomePropretario = "Victor Hernandes";
            _comando.ProprietarioDocumento = "99999999999";
            _comando.DocumentoProprietarioPagamento = ETipoDocumentos.CPF;
            _comando.Rua = "teste";
            _comando.Numero = "12345";
            _comando.Complemento = "teste";
            _comando.Bairro = "teste";
            _comando.Cidade = "teste";
            _comando.Estado = "te";
            _comando.CEP = "99999999";
            _comando.EmailPagamento = "123@hernandes.com";

            _cabecalho.Cabecalho(_comando);
            Assert.AreEqual(false, _cabecalho.Valid);
        }


        [TestMethod]
        public void DadosValido()
        {
            _comando.PrimeiroNome = "Victor";
            _comando.UltimoNome = "Santos";
            _comando.Documento = "99999999997";
            _comando.Email = "123@hernandes.com";
            _comando.CodigoDaTransicao = "1234567";
            _comando.NumeroPagamento = "123456789";
            _comando.DataPagamento = DateTime.Now;
            _comando.DataExpiracao = DateTime.Now.AddMonths(1);
            _comando.Total = 60;
            _comando.TotalPagamento = 60;
            _comando.NomePropretario = "Victor Hernandes";
            _comando.ProprietarioDocumento = "99999999999";
            _comando.DocumentoProprietarioPagamento = ETipoDocumentos.CPF;
            _comando.Rua = "teste";
            _comando.Numero = "12345";
            _comando.Complemento = "teste";
            _comando.Bairro = "teste";
            _comando.Cidade = "teste";
            _comando.Estado = "te";
            _comando.CEP = "99999999";
            _comando.EmailPagamento = "123@hernandes.com";


            _cabecalho.Cabecalho(_comando);
            Assert.IsTrue(_cabecalho.Valid);
        }

    }
}
