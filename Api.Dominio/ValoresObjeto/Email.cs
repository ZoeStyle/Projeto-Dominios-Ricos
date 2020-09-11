using Api.Compartilhamento.ValorObjeto;
using Flunt.Validations;

namespace Api.Dominio.ValorObjeto
{
    public class Email : ValorObj
    {
        public Email(string emdereco)
        {
            Emdereco = emdereco;

            AddNotifications(new Contract()
                .Requires()
                .IsEmail(Emdereco, "email.anddress", "E-mail invalido")
            );

            // new Contract().Requires().IsEmail(Anddress, "Email.Anddress","E-mail invalido" )
        }

        public string Emdereco { get; private set; }
    }
}