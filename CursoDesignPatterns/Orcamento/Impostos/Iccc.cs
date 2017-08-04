using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public class Iccc: IImposto
    {
        public double Calcula(CursoDesignPatterns.Orcamento.Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.05;

            if (orcamento.Valor > 3000)
                return (orcamento.Valor*0.08) + 30.0;

            return orcamento.Valor*0.07;
        }
    }
}
