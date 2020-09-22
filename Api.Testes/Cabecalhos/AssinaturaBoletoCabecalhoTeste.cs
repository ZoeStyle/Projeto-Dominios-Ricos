using System;
using Api.Dominio.Cabecalho;
using Api.Dominio.Comando;
using Api.Dominio.Enumerados;
using Api.Testes.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Api.Testes.Cabecalhos
{
    [TestClass]
    public class AssinaturaBoletoCabecalhoTeste
    {
        private AssinaturaBoletoCabecalho _cabecalho;
        private ComandoCriarAssinaturaBoleto _comando;

        public AssinaturaBoletoCabecalhoTeste()
        {
            _cabecalho = new AssinaturaBoletoCabecalho(new FakeAlunoRepositorio(), new FakeServicoEmail());
            _comando = new ComandoCriarAssinaturaBoleto();

        }

        [TestMethod]
        public void DocumentoExistenteValido()
        {
            
            _comando.PrimeiroNome = "Victor";
            _comando.UltimoNome = "Santos";
            _comando.Documento = "99999999999";
            _comando.Email = "123@hernandes.com";
            _comando.CodigoDeBarras = "123456789";
            _comando.NumeroBoleto = "123456789";
            _comando.NumeroPagamento = "123121";
            _comando.DataPagamento = DateTime.Now;
            _comando.DataExpiracao = DateTime.Now.AddMonths(1);
            _comando.Total = 60;
            _comando.TotalPagamento = 60;
            _comando.NumeroDocumento = "Victor Company";
            _comando.ProprietarioDocumento = "12345678988";
            _comando.DocumentoProprietarioPagamento = ETipoDocumentos.CPF;
            _comando.Rua = "Rua do teste";
            _comando.Numero = "12";
            _comando.Complemento = "";
            _comando.Bairro = "Teste";
            _comando.Cidade = "Teste";
            _comando.Estado = "Teste";
            _comando.CEP = "12345678";
            _comando.EmailPagamento = "hello@hernandes.com";

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
            _comando.CodigoDeBarras = "123456789";
            _comando.NumeroBoleto = "123456789";
            _comando.NumeroPagamento = "123121";
            _comando.DataPagamento = DateTime.Now;
            _comando.DataExpiracao = DateTime.Now.AddMonths(1);
            _comando.Total = 60;
            _comando.TotalPagamento = 60;
            _comando.NumeroDocumento = "Victor Company";
            _comando.ProprietarioDocumento = "12345678988";
            _comando.DocumentoProprietarioPagamento = ETipoDocumentos.CPF;
            _comando.Rua = "Rua do teste";
            _comando.Numero = "12";
            _comando.Complemento = "";
            _comando.Bairro = "Teste";
            _comando.Cidade = "Teste";
            _comando.Estado = "Teste";
            _comando.CEP = "12345678";
            _comando.EmailPagamento = "hello@hernandes.com";

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
            _comando.CodigoDeBarras = "123456789";
            _comando.NumeroBoleto = "123456789";
            _comando.NumeroPagamento = "123121";
            _comando.DataPagamento = DateTime.Now;
            _comando.DataExpiracao = DateTime.Now.AddMonths(1);
            _comando.Total = 60;
            _comando.TotalPagamento = 60;
            _comando.NumeroDocumento = "Victor Company";
            _comando.ProprietarioDocumento = "12345678988";
            _comando.DocumentoProprietarioPagamento = ETipoDocumentos.CPF;
            _comando.Rua = "Rua do teste";
            _comando.Numero = "12";
            _comando.Complemento = "123456789";
            _comando.Bairro = "Teste";
            _comando.Cidade = "Teste";
            _comando.Estado = "ts";
            _comando.CEP = "12345678";
            _comando.EmailPagamento = "hello@hernandes.com";

            _cabecalho.Cabecalho(_comando);
            Assert.AreEqual(true, _cabecalho.Valid);
        }

    }
}
