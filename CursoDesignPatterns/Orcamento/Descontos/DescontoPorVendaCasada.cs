using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Orcamento.Descontos
{
    public class DescontoPorVendaCasada: IDesconto
    {
        public double Desconta(Orcamento orcamento)
        {
            if (AconteceuVendaCasadaEm(orcamento))
                return orcamento.Valor*0.05;

            return Proximo.Desconta(orcamento);
        }

        private bool AconteceuVendaCasadaEm(Orcamento orcamento)
        {
            return Existe("LAPIS", orcamento) && Existe("CANETA", orcamento);
        }

        private bool Existe(string nomeItem, Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeItem))
                    return true;
            }

            return false;
        }

        public IDesconto Proximo { get; set; }
    }
}
