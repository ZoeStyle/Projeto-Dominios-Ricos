using Api.Compartilhamento.ValorObjeto;
using Flunt.Validations;

namespace Api.Dominio.ValorObjeto
{
    public class Endereco : ValorObj
    {
        public Endereco(string rua, string numero, string complemento, string bairro, string cidade, string estado, string cEP)
        {
            Rua = rua;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            CEP = cEP;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(rua, 3, "Rua", "A rua deve conter mais de 3 caracteres")
                .HasMinLen(numero, 1, "Numero", "O número deve conter mais de 1 caracter")
                .HasMinLen(complemento, 3, "Complemento", "O complemento deve conter mais de 3 caracteres")
                .HasMinLen(bairro, 3, "Bairro", "O bairro deve conter mais de 3 caracteres")
                .HasMinLen(cidade, 3, "Cidade", "A cidade deve conter mais de 3 caracteres")
                .HasMinLen(estado, 1, "Estado", "O estado deve conter mais de 1 caracter")
                .HasMinLen(cEP, 3, "CEP", "O CEP deve conter mais de 3 caracteres")
                .HasMaxLen(rua, 50, "Rua", "O número de caracteres foram execidos")
                .HasMaxLen(numero, 5, "Numero", "O número de caracteres foram execidos")
                .HasMaxLen(complemento, 50, "Complemento", "O número de caracteres foram execidos")
                .HasMaxLen(bairro, 50, "Bairro", "O número de caracteres foram execidos")
                .HasMaxLen(cidade, 50, "Cidade", "O número de caracteres foram execidos")
                .HasMaxLen(estado, 2, "Estado", "O número de caracteres foram execidos")
                .HasMaxLen(cEP, 8, "CEP", "O número de caracteres foram execidos")

            );
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string CEP { get; private set; }
    }
}