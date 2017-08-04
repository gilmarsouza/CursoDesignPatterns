using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns.Investimentos.Filtros
{
    public class FiltroMesmoMes: Filtro
    {
        public FiltroMesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMesmoMes(): base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            var filtrada = new List<Conta>();

            foreach (var conta in contas)
            {
                if ((conta.DataAbertura.Month == DateTime.Now.Month) && 
                    (conta.DataAbertura.Year == DateTime.Now.Year))
                    filtrada.Add(conta);
            }

            foreach (var conta in Proximo(contas))
            {
                filtrada.Add(conta);
            }

            return filtrada;
        }
    }
}
