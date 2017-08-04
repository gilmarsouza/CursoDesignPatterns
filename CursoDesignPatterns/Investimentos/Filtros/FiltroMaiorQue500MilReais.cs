using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimentos.Filtros
{
    public class FiltroMaiorQue500MilReais: Filtro
    {
        public FiltroMaiorQue500MilReais(Filtro outroFiltro): base(outroFiltro) { }

        public FiltroMaiorQue500MilReais(): base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            var filtrada = new List<Conta>();

            foreach (var conta in contas)
            {
                if (conta.Saldo > 50000) filtrada.Add(conta);
            }

            foreach (var conta in Proximo(contas))
            {
                filtrada.Add(conta);
            }

            return filtrada;
        }
    }
}
