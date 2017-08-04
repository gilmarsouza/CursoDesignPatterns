namespace CursoDesignPatterns.Orcamento.Descontos
{
    public class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            var d1 = new DescontoPorCincoItens();
            var d2 = new DescontoPorMaisDeQuinhentosReais();
            var d3 = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;

            return d1.Desconta(orcamento);
        }
    }
}
