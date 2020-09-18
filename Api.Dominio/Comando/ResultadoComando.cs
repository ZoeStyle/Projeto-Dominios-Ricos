using Api.Compartilhamento.Comandos;

namespace Api.Dominio.Comando
{
    public class ResultadoComando : IResultadoComando
    {
        public ResultadoComando()
        {
            
        }
        
        public ResultadoComando(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }

        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
    }
}