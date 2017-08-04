namespace CursoDesignPatterns.Interfaces
{
    public interface IDesconto
    {
        double Desconta(Orcamento.Orcamento orcamento);
        IDesconto Proximo { get; set; }
    }
}
