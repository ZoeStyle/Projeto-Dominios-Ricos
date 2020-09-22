using Api.Dominio.Entidade;
using Api.Dominio.Repositorio;
using Api.Dominio.Servicos;

namespace Api.Testes.Fakes
{
    public class FakeServicoEmail : IServicoEmail
    {
        public void Enviar(string to, string email, string subject, string body)
        {
            
        }
    }
}