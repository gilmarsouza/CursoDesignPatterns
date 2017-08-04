using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public class Icms: IImposto
    {
        public double Calcula(CursoDesignPatterns.Orcamento.Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50;
        }
    }
}
