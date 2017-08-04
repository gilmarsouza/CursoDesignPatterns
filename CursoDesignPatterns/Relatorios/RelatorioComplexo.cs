using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns.Relatorios
{
    public class RelatorioComplexo: Relatorio
    {
        public RelatorioComplexo(List<Conta> listaContas)
        {
            this.contas = listaContas;
        }

        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
            Console.WriteLine("Avenida Jacinto Rego, 171");
            Console.WriteLine("(44) 96598-6542");
        }

        protected override void Rodape()
        {
            Console.WriteLine("banco@banco.com.br");
            Console.WriteLine(DateTime.Now);
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (var conta in contas)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", 
                    conta.Titular, conta.Agencia, conta.NumeroConta, conta.Saldo);
            }
        }
    }
}
