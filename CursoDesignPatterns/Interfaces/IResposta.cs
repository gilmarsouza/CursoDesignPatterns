using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns.Interfaces
{
    public interface IResposta
    {
        void Responde(Requisicao req, Conta conta);
    }
}
