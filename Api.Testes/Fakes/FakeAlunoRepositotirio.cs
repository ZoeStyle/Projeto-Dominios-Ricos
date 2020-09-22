using Api.Dominio.Entidade;
using Api.Dominio.Repositorio;

namespace Api.Testes.Fakes
{
    public class FakeAlunoRepositorio : IAlunoRepositorio
    {
        public void CriarAssinatura(Aluno aluno)
        {
                
        }

        public bool ExisteDocumento(string documento)
        {
            if(documento == "99999999999")
                return true;

            return false;
        }

        public bool ExisteEmail(string email)
        {
            if(email == "hello@hernandes.com")
                return true;
            
            return false;
        }
    }
}