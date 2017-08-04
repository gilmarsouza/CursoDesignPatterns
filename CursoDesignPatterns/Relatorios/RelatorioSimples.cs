using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns.Relatorios
{
    public class RelatorioSimples: Relatorio
    {
        public RelatorioSimples(List<Conta> listaContas)
        {
            this.contas = listaContas;
        }

        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Rodape()
        {
            Console.WriteLine("(44) 91223-9554");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine("{0} - {1}", conta.Titular, conta.Saldo);
            }
        }
    }
}
