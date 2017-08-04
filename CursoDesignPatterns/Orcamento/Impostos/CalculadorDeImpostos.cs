using System;
using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(CursoDesignPatterns.Orcamento.Orcamento orcamento, IImposto imposto)
        {
            var valorImposto = imposto.Calcula(orcamento);
            Console.WriteLine(valorImposto);
        }
    }
}
