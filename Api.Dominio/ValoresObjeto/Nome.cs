using Api.Compartilhamento.ValorObjeto;
using Flunt.Validations;

namespace Api.Dominio.Entidade
{
    public class Nome : ValorObj
    {
        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(primeiroNome, 3, "PrimeiroNome", "O Nome deve conter no minimo 3 caracteres")
                .HasMinLen(ultimoNome, 3, "UltimoNome", "O Sobrenome deve conter no minimo 3 caracteres")
                .HasMaxLen(primeiroNome, 20, "PrimeiroNome", "O Nome deve conter no minimo 3 caracteres")
                .HasMaxLen(primeiroNome, 20, "PrimeiroNome", "O Sobrenome deve conter no minimo 3 caracteres")
            );
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
    }
}