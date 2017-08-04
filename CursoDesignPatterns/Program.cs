using System;
using System.Collections.Generic;
using CursoDesignPatterns.Investimentos;
using CursoDesignPatterns.Investimentos.Respostas;
using CursoDesignPatterns.Investimentos.TiposInvestidores;
using CursoDesignPatterns.Orcamento;
using CursoDesignPatterns.Orcamento.Descontos;
using CursoDesignPatterns.Orcamento.Impostos;
using CursoDesignPatterns.Relatorios;

namespace CursoDesignPatterns
{
    class Program
    {
        private static Orcamento.Orcamento orcamento;
        private static List<Conta> contas; 
        

        static void Main(string[] args)
        {
            //TestandoImpostos();
            //TestandoInvestimentos();
            //TestandoDescontos();
            //TestaCorrente();
            //TestaCadeiaResposta();
            //TestarRelatorios();



            TesteImpostoMuitoAltoCombinado();

            Console.ReadKey();
        }

        public static void TesteImpostoMuitoAltoCombinado()
        {
            CriaOrcamento();

            var iss = new Iss();
            var impostoMuitoAlto = new ImpostoMuitoAlto(iss);

            Console.WriteLine("Teste Imposto Muito Alto (Estilo Brasil)");
            Console.WriteLine();

            Console.WriteLine("Cálcula Imposto ISS: {0:C}", iss.Calcula(orcamento));
            Console.WriteLine("Cálcula Imposto 'Muito Alto': {0:C}", impostoMuitoAlto.Calcula(orcamento));
        }

        public static void TesteImpostoComposto()
        {
            CriaOrcamento();

            var iccp = new Icpp(null);
            var ikcv = new Ikcv(iccp);
            var ihit = new Ihit(ikcv);

            Console.WriteLine("Teste Imposto Composto");
            Console.WriteLine();

            Console.WriteLine("Cálcula Imposto ICCP: {0:C}", iccp.Calcula(orcamento));
            Console.WriteLine("Cálcula Imposto IKCV: {0:C}", ikcv.Calcula(orcamento));

            //Forçar Item Repetido
            orcamento.AdicionaItem(new Item("PINCEL", 250.0));
            Console.WriteLine("Cálcula Imposto IHIT: {0:C}", ihit.Calcula(orcamento));
            Console.WriteLine();
        }



        public static void TestarRelatorios()
        {
            CriarListaContas();

            var relatorioSimples = new RelatorioSimples(contas);
            var relatorioComplexo = new RelatorioComplexo(contas);

            Console.WriteLine("************ Relatório Simples ************");
            relatorioSimples.Imprime();

            Console.WriteLine();
            Console.WriteLine("************ Relatório Complexo ************");
            relatorioComplexo.Imprime();
        }


        public static void TestaImpostoCondicional()
        {
            CriaOrcamento();

            var iccp = new Icpp(null);
            var ikcv = new Ikcv(null);
            var ihit = new Ihit(null);

            Console.WriteLine("Teste Imposto Condicional");
            Console.WriteLine();

            Console.WriteLine("Cálcula Imposto ICCP: {0:C}", iccp.Calcula(orcamento));
            Console.WriteLine("Cálcula Imposto IKCV: {0:C}", ikcv.Calcula(orcamento));

            //Forçar Item Repetido
            orcamento.AdicionaItem(new Item("PINCEL", 250.0));
            Console.WriteLine("Cálcula Imposto IHIT: {0:C}", ihit.Calcula(orcamento));
            Console.WriteLine();
        }

        public static void TestaCadeiaResposta()
        {
            var r3 = new RespostaEmXml();
            var r2 = new RespostaEmPorcento(r3);
            var r1 = new RespostaEmCsv(r2);

            var conta = new Conta("Fulano de Tal", "111", "132", 123658.96);
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

            CriaOrcamento();

            double desconto = d1.Desconta(orcamento);
            Console.WriteLine(desconto);
        }


        public static void TestandoDescontos()
        {
            var calculador = new CalculadorDeDescontos();

            CriaOrcamento();

            var desconto = calculador.Calcula(orcamento);

            Console.WriteLine(string.Format("IDesconto calculado: {0}", desconto));
        }


        public static void TestandoInvestimentos()
        {
            var conservador = new Conservador();
            var moderado = new Moderado();
            var arrojado = new Arrojado();

            var conta = new Conta("Fulano", "111", "132", 1500);

            var realizador = new RealizadorDeInvestimentos();

            realizador.Realiza(conta, conservador);
            realizador.Realiza(conta, moderado);
            realizador.Realiza(conta, arrojado);
        }

        public static void TestandoImpostos()
        {
            var iss = new Iss(null);
            var icms = new Icms(null);
            var iccc = new Iccc(null);

            CriaOrcamento();

            var calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            calculador.RealizaCalculo(orcamento, iccc);
        }

        private static void CriaOrcamento()
        {
            orcamento = new Orcamento.Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("BORRACHA", 250.0));
            orcamento.AdicionaItem(new Item("APONTADOR", 250.0));
            orcamento.AdicionaItem(new Item("CADERNO", 250.0));
            orcamento.AdicionaItem(new Item("PINCEL", 250.0));
        }

        private static void CriarListaContas()
        {
            contas = new List<Conta>();

            contas.Add(new Conta("Fulano de tal", "123-45", "32121-6", 500.00));
            contas.Add(new Conta("Beltrano de tal", "123-45", "123-5", 500.00));
            contas.Add(new Conta("Ciclano de tal", "3215-45", "1456-7", 500.00));
            contas.Add(new Conta("Fulano de Birl", "12323-546", "12325-8", 500.00));
            contas.Add(new Conta("Gilmento de Pau", "1234165-9", "2165-8", 500.00));
            contas.Add(new Conta("Luis Inácio", "32135-8", "165-8", 500.00));
            contas.Add(new Conta("Rosineide Josicleia", "12354-7", "1258-9", 500.00));
        }

    }
}
