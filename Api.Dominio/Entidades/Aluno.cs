using System.Collections.Generic;
using System.Linq;

// A classe construtor serve para falicitar a leitura do código nas outras classes
// A função IList => Listar todas assinaturas/Aluno
// Todos os metodos encontra-se com private set pois simente nela podera setar os valores
// IReadOnlyCollection => lista somente os dados de uma classe, ele priva alterações por fora
// Para adionar qualquer assinatura para o aluno deve-se chamar o método AdicionarAssinatura 

namespace Api.Dominio.Entidade
{
    public class Aluno
    {
        private IList<Assinatura> _assinaturas;
        public Aluno(string primeiroNome, string ultimoNome, string documento, string email)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get{ return _assinaturas.ToArray();}}

        public void AdicionarAssinatura(Assinatura assinatura)
        {
            // Percorre toda classe de assinaturas com os dados do aluno
            // caso o aluno possua alguma assinatura cancela a mesma
            foreach (var Ass in Assinaturas)
                Ass.Desativar();

            // Adiciona uma nova assinatura com os dados do cliente
            _assinaturas.Add(assinatura);
        }
    }
}