using System;
using System.Collections.Generic;
using System.Linq;
using Api.Compartilhamento.Entidades;

// A classe construtor serve para falicitar a leitura do código nas outras classes
// A função IList => Listar todas pagamentos/Assinatura
// Todos os metodos encontra-se com private set pois simente nela podera setar os valores
// IReadOnlyCollection => lista somente os dados de uma classe, ele priva alterações por fora
// Para Ativar ou desativar qualquer assinatura do Alunodeve-se chamar os métodos Ativar() ou Desativar() 
// Para adionar qualquer assinatura para o aluno deve-se chamar o método AdicionarAssinatura 

namespace Api.Dominio.Entidade
{
    public class Assinatura : Entidades
    {
        private IList<Pagamento> _pagamento;
        public Assinatura(DateTime? dataExpiracao)
        {
            DataCriacao = DateTime.Now;
            DataUltimaAtualizacao = DateTime.Now;
            DataExpiracao = dataExpiracao;
            Ativo = true;
            _pagamento = new List<Pagamento>();
        }

        // => Tipo primitivo que captura a data de criação da assinatura
        public DateTime DataCriacao { get; private set; }
        // => Tipo primitivo que captura a ultima data de atualização na assinatura   
        public DateTime DataUltimaAtualizacao { get; private set; }
        // => O sinal ? significa que ele pode ser nulo nulable()
        // => Tipo primitivo que registra a data de expiração do contrato da assintura
        public DateTime? DataExpiracao { get; private set; }
        // => Tipo primitivo que registro se a assinatura esta ativa ou inativa
        public bool Ativo { get; private set; }
        // => Exibe somente a lista de pagamentos realizados pela assinatura
        // => não é possível sobreescrever o método para realizar tal feito é necessario chamar o método AdicionarPagamento
        public IReadOnlyCollection<Pagamento> Pagamentos { get { return _pagamento.ToArray(); } }
        // => Método responsável para adicionar o pagamento 
        public void AdicionarPagamento(Pagamento pagamento)
        {
            _pagamento.Add(pagamento);
        }
        // => Método que ativa a assinatura do aluno
        public void Ativar()
        {
            Ativo = true;
            DataUltimaAtualizacao = DateTime.Now;
        }
        // => Método que inativa a assinatura do aluno
        public void Desativar()
        {
            Ativo = false;
            DataUltimaAtualizacao = DateTime.Now;
        }
    }
}