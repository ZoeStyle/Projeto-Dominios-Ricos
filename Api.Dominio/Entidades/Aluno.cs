using System.Collections.Generic;
using System.Linq;
using Api.Compartilhamento.Entidades;
using Api.Dominio.ValorObjeto;

// A classe construtor serve para falicitar a leitura do código nas outras classes
// A função IList => Listar todas assinaturas/Aluno
// Todos os metodos encontra-se com private set pois simente nela podera setar os valores
// IReadOnlyCollection => lista somente os dados de uma classe, ele priva alterações por fora
// Para adionar qualquer assinatura para o aluno deve-se chamar o método AdicionarAssinatura 
// A utilização dos dominios ricos facilita na hora do teste de unidade

namespace Api.Dominio.Entidade
{
    public class Aluno : Entidades
    {
        private IList<Assinatura> _assinaturas;
        public Aluno(Nome nome, Documento documento, Email email)
        {
            Nome = nome;
            Documento = documento;
            Email = email;
            _assinaturas = new List<Assinatura>();

            AddNotifications(nome, documento,email);
        }

        // => Este metodo voce deve informar o Primeiro nome e ultimo nome
        public Nome Nome { get; set; }
        // => Este metodo voce informa o numero do documento e o tipo de documento cpf e cnpj
        public Documento Documento { get; private set; }
        // => Este metodo você informa o  endereco de email
        public Email Email { get; private set; }
        // => Este método vc informa todos os campos para o endereco (Rua, numero,Complemento, Cidade, Bairro,Estado,CEP)
        public Endereco Endereco { get; private set; }
        // => Volta uma lista de assinatura que não é possivel reescrever 
        // => Para adicionar outro registro deve-se realizar pelo metodo AdicionarAssinatura
        public IReadOnlyCollection<Assinatura> Assinaturas { get { return _assinaturas.ToArray(); } }

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