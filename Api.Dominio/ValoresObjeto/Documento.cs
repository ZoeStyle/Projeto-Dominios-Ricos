using Api.Dominio.Enumerados;
using Api.Compartilhamento.ValorObjeto;
using Flunt.Validations;

namespace Api.Dominio.Entidade
{
    public class Documento : ValorObj
    {
        public Documento(string numero, ETipoDocumentos tipo)
        {
            Numero = numero;
            Tipo = tipo;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validacao(), "Numero do documento", "Documento incalido")
            );
        }

        public string Numero { get; private set; }
        public ETipoDocumentos Tipo { get; private set; }

        private bool Validacao()
        {
            if (Tipo == ETipoDocumentos.CNPJ && Numero.Length == 14)
                return true;
            if (Tipo == ETipoDocumentos.CPF && Numero.Length == 11)
                return true;
            
            return false;
            
        }
    }
}