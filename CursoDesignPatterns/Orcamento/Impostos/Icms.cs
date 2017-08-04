using System;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public class Icms: Imposto
    {
        public Icms(Imposto outroImposto): base(outroImposto) { }

        public Icms() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.05) + 50 + CalculoDoOutroImposto(orcamento);
        }
    }
}
