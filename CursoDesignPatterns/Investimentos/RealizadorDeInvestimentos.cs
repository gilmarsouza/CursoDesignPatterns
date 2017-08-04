using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Interfaces;
using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns
{
    public class RealizadorDeInvestimentos
    {
        public void Realiza(Conta conta, IInvestimento investimento)
        {
            double rendimento = investimento.Calcula(conta);
            conta.Deposita(rendimento * 0.75);
            Console.WriteLine(string.Format("Novo saldo: {0:C}", conta.Saldo));
        }
    }
}
