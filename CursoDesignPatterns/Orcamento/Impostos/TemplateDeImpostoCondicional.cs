using System;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public abstract class TemplateDeImpostoCondicional: Imposto
    {
        protected TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        protected TemplateDeImpostoCondicional() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);

            return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
