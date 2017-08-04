using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public class Iss: IImposto
    {
        public double Calcula(CursoDesignPatterns.Orcamento.Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
