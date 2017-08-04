using System;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public class Iccc: Imposto
    {
        public Iccc(Imposto outroImposto): base(outroImposto) { }
        public Iccc() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);

            if (orcamento.Valor > 3000)
                return (orcamento.Valor * 0.08) + 30.0 + CalculoDoOutroImposto(orcamento);

            return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
        }
    }
}
