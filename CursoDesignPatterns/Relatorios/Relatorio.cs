using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Investimentos;

namespace CursoDesignPatterns.Relatorios
{
    public abstract class Relatorio
    {
        protected IList<Conta> contas;
        
        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> contas);

        public void Imprime()
        {
            Cabecalho();
            Corpo(contas);
            Rodape();
        }
    }
}
