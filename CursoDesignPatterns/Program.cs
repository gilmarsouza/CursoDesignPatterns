using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Investimentos;
using CursoDesignPatterns.Investimentos.Respostas;
using CursoDesignPatterns.Investimentos.TiposInvestidores;
using CursoDesignPatterns.Orcamento;
using CursoDesignPatterns.Orcamento.Descontos;
using CursoDesignPatterns.Orcamento.Impostos;

namespace CursoDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestandoImpostos();
            //TestandoInvestimentos();
            //TestandoDescontos();
            //TestaCorrente();
            TestaCadeiaResposta();

            Console.ReadKey();
        }

        public static void TestaCadeiaResposta()
        {
            var r3 = new RespostaEmXml();
            var r2 = new RespostaEmPorcento(r3);
            var r1 = new RespostaEmCsv(r2);

            var conta = new Conta("Fulano de Tal", 123658.96);
            var requisicao = new Requisicao(Formato.Xml);

            r1.Responde(requisicao, conta);
        }


        public static void TestaCorrente()
        {
            var d1 = new DescontoPorCincoItens();
            var d2 = new DescontoPorMaisDeQuinhentosReais();
            var d3 = new DescontoPorVendaCasada();
            var d4 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = d4;

            Orcamento.Orcamento orcamento = new Orcamento.Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("BORRACHA", 250.0));

            double desconto = d1.Desconta(orcamento);
            Console.WriteLine(desconto);
        }


        public static void TestandoDescontos()
        {
            var calculador = new CalculadorDeDescontos();

            var orcamento = new Orcamento.Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("BORRACHA", 250.0));
            orcamento.AdicionaItem(new Item("APONTADOR", 250.0));
            orcamento.AdicionaItem(new Item("CADERNO", 250.0));
            orcamento.AdicionaItem(new Item("PINCEL", 250.0));

            var desconto = calculador.Calcula(orcamento);

            Console.WriteLine(string.Format("IDesconto calculado: {0}", desconto));
        }


        public static void TestandoInvestimentos()
        {
            var conservador = new Conservador();
            var moderado = new Moderado();
            var arrojado = new Arrojado();

            var conta = new Conta("Fulano", 1500);

            var realizador = new RealizadorDeInvestimentos();

            realizador.Realiza(conta, conservador);
            realizador.Realiza(conta, moderado);
            realizador.Realiza(conta, arrojado);
        }

        public static void TestandoImpostos()
        {
            var iss = new Iss();
            var icms = new Icms();
            var iccc = new Iccc();

            var orcamento = new Orcamento.Orcamento(500.0);

            var calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, iccc);
        }


    }
}
