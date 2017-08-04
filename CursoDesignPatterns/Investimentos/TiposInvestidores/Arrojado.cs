using System;
using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Investimentos.TiposInvestidores
{
    public class Arrojado: IInvestimento
    {
        private Random random;

        public Arrojado()
        {
            random = new Random();
        }

        public double Calcula(Conta conta)
        {
            var chute = random.Next(10);

            if (chute >= 0 && chute <= 1) return conta.Saldo*0.5;

            if (chute >= 2 && chute <= 4) return conta.Saldo*0.3;

            return conta.Saldo*0.006;
        }
    }
}
