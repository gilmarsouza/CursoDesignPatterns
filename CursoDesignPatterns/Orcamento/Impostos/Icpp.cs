using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public class Icpp: TemplateDeImpostoCondicional
    {
        public Icpp(Imposto outroImposto) : base(outroImposto) { }

        public Icpp() : base() { }

        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor*0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor*0.05;
        }
    }
}
