using Api.Compartilhamento.Comandos;

namespace Api.Compartilhamento.Cabecalhos
{
    public interface ICabecalhos<T> 
    where T : IComando
    {
        IResultadoComando Cabecalho(T comando);
    }
}