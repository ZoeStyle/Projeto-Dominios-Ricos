namespace Api.Dominio.Servicos
{
    public interface IServicoEmail
    {
        void Enviar(string to, string email, string subject, string body);
    }
}