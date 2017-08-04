using System;
using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Investimentos.TiposInvestidores
{
    public class Moderado: IInvestimento
    {
        private Random random;

        public Moderado()
        {
            random = new Random();
        }

        public double Calcula(Conta conta)
        {
            if (random.Next(2) == 0)
                return conta.Saldo*0.025;

            return conta.Saldo*0.007;
        }
    }
}
