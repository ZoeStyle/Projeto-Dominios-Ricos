using System;
using Api.Dominio.Cabecalho;
using Api.Dominio.Comando;
using Api.Dominio.Enumerados;
using Api.Testes.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Testes.Cabecalhos
{
    [TestClass]
    public class AssinaturaCreditoCabecalhoTeste
    {
        private AssinaturaCreditoCabecalho _cabecalho;
        private ComandoCriarAssinaturaCredito _comando;

        public AssinaturaCreditoCabecalhoTeste()
        {
            _cabecalho = new AssinaturaCreditoCabecalho(new FakeAlunoRepositorio(), new FakeServicoEmail());
            _comando = new ComandoCriarAssinaturaCredito();

        }

        [TestMethod]
        public void DocumentoExistenteValido()
        {
            _comando.PrimeiroNome = "Victor";
            _comando.UltimoNome = "Santos";
            _comando.Documento = "99999999999";
            _comando.Email = "123@hernandes.com";
            _comando.NomeTitular = "Victor Hernandes Santos";
            _comando.NumeroDoCartao = "1234567898";
            _comando.UltimaTransacao = "123548";
            _comando.NumeroPagamento = "123546";
            _comando.DataPagamento = DateTime.Now;
            _comando.DataExpiracao = DateTime.Now.AddMonths(1);
            _comando.Total = 60;
            _comando.TotalPagamento = 60;
            _comando.NomePropretario = "Victor Hernandes Santos";
            _comando.ProprietarioDocumento = "9999999999";
            _comando.DocumentoProprietarioPagamento = ETipoDocumentos.CPF;
            _comando.Rua = "Teste";
            _comando.Numero = "12345";
            _comando.Complemento = "teste";
            _comando.Bairro = "Teste";
            _comando.Cidade = "Teste";
            _comando.Estado = "Ts";
            _comando.CEP = "00000000";
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
            _comando.NomeTitular = "Victor Hernandes Santos";
            _comando.NumeroDoCartao = "1234567898";
            _comando.UltimaTransacao = "123548";
            _comando.NumeroPagamento = "123546";
            _comando.DataPagamento = DateTime.Now;
            _comando.DataExpiracao = DateTime.Now.AddMonths(1);
            _comando.Total = 60;
            _comando.TotalPagamento = 60;
            _comando.NomePropretario = "Victor Hernandes Santos";
            _comando.ProprietarioDocumento = "9999999999";
            _comando.DocumentoProprietarioPagamento = ETipoDocumentos.CPF;
            _comando.Rua = "Teste";
            _comando.Numero = "12345";
            _comando.Complemento = "teste";
            _comando.Bairro = "Teste";
            _comando.Cidade = "Teste";
            _comando.Estado = "Ts";
            _comando.CEP = "00000000";
            _comando.EmailPagamento = "123@hernandes.com";

            _cabecalho.Cabecalho(_comando);
            Assert.AreEqual(false, _cabecalho.Valid);
        }


        [TestMethod]
        public void DadosValido()
        {
            _comando.PrimeiroNome = "Victor";
            _comando.UltimoNome = "Santos";
            _comando.Documento = "99999999998";
            _comando.Email = "123@hernandes.com";
            _comando.NomeTitular = "Victor Hernandes Santos";
            _comando.NumeroDoCartao = "1234567898";
            _comando.UltimaTransacao = "123548";
            _comando.NumeroPagamento = "123546";
            _comando.DataPagamento = DateTime.Now;
            _comando.DataExpiracao = DateTime.Now.AddMonths(1);
            _comando.Total = 60;
            _comando.TotalPagamento = 60;
            _comando.NomePropretario = "Victor Hernandes Santos";
            _comando.ProprietarioDocumento = "9999999999";
            _comando.DocumentoProprietarioPagamento = ETipoDocumentos.CPF;
            _comando.Rua = "Teste";
            _comando.Numero = "12345";
            _comando.Complemento = "teste";
            _comando.Bairro = "Teste";
            _comando.Cidade = "Teste";
            _comando.Estado = "Ts";
            _comando.CEP = "00000000";
            _comando.EmailPagamento = "123@hernandes.com";

            _cabecalho.Cabecalho(_comando);
            Assert.IsTrue(_cabecalho.Valid);
        }
    }
}
