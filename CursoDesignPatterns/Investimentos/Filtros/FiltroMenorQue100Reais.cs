using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimentos.Filtros
{
    public class FiltroMenorQue100Reais: Filtro
    {
        public FiltroMenorQue100Reais(Filtro outroFiltro): base(outroFiltro) { }

        public FiltroMenorQue100Reais(): base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            var filtrada = new List<Conta>();

            foreach (var conta in contas)
            {
                if (conta.Saldo < 100) filtrada.Add(conta);
            }

            foreach (var conta in Proximo(contas))
            {
                filtrada.Add(conta);
            }

            return filtrada;
        }
    }
}
