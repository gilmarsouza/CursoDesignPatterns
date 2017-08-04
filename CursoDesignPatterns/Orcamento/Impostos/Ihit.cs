using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public class Ihit: TemplateDeImpostoCondicional
    {
        protected override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.GroupBy(x => x.Nome).Any(y => y.Count() > 1);
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor*0.13 + 100.00;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01 * orcamento.Itens.Count;
        }
    }
}
