using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Orcamento.Descontos
{
    public class SemDesconto: IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconta(Orcamento orcamento)
        {
            return 0;
        }
    }
}
