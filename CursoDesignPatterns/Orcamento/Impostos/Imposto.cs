using CursoDesignPatterns.Orcamento;

namespace CursoDesignPatterns.Orcamento.Impostos
{
    public abstract class Imposto
    {
        private readonly Imposto outroImposto;

        public Imposto(Imposto outroImposto)
        {
            this.outroImposto = outroImposto;
        }

        public Imposto()
        {
            this.outroImposto = null;
        }

        protected double CalculoDoOutroImposto(Orcamento orcamento)
        {
            if (outroImposto == null) return 0;
            return outroImposto.Calcula(orcamento);
        }

        public abstract double Calcula(Orcamento orcamento);
    }
}
