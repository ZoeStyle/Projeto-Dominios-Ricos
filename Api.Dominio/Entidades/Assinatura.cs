using System;
using System.Collections.Generic;
using System.Linq;

// A classe construtor serve para falicitar a leitura do código nas outras classes
// A função IList => Listar todas pagamentos/Assinatura
// Todos os metodos encontra-se com private set pois simente nela podera setar os valores
// IReadOnlyCollection => lista somente os dados de uma classe, ele priva alterações por fora
// Para Ativar ou desativar qualquer assinatura do Alunodeve-se chamar os métodos Ativar() ou Desativar() 
// Para adionar qualquer assinatura para o aluno deve-se chamar o método AdicionarAssinatura 

namespace Api.Dominio.Entidade
{
    public class Assinatura
    {
        private IList<Pagamento> _pagamento;
        public Assinatura( DateTime? dataExpiracao)
        {
            DataCriacao = DateTime.Now;
            DataUltimaAtualizacao = DateTime.Now;
            DataExpiracao = dataExpiracao;
            Ativo = true;
            _pagamento = new List<Pagamento>();
        }

        public DateTime DataCriacao { get; private set; }
        public DateTime DataUltimaAtualizacao { get; private set; }
        // => O sinal ? significa que ele pode ser nulo nulable()
        public DateTime? DataExpiracao { get; private set; }
        public bool Ativo { get; private set; }
        public IReadOnlyCollection<Pagamento> Pagamentos { get { return _pagamento.ToArray();} }

        public void AdicionarPagamento(Pagamento pagamento)
        {
            _pagamento.Add(pagamento);
        }

        public void Ativar()
        {
            Ativo = true;
            DataUltimaAtualizacao = DateTime.Now;
        }
        
        public void Desativar()
        {
            Ativo = false;
            DataUltimaAtualizacao = DateTime.Now;
        }
    }
}