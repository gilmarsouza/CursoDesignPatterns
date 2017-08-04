namespace CursoDesignPatterns.Orcamento.Impostos
{
    public class Iss: Imposto
    {
        public Iss(Imposto outroImposto) : base(outroImposto) { }
        public Iss() : base() { }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
