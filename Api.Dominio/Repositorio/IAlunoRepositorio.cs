using Api.Dominio.Entidade;

namespace Api.Dominio.Repositorio
{
   public interface IAlunoRepositorio
   {
       bool ExisteDocumento(string documento);
       bool ExisteEmail(string email);
       void CriarAssinatura(Aluno aluno);
   } 
}