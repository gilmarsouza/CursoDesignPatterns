using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Investimentos.Respostas
{
    public class RespostaEmPorcento: IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmPorcento(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public RespostaEmPorcento()
        {
            OutraResposta = null;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.Porcento)
                Console.WriteLine("{0}%{1}", conta.Titular, conta.Saldo);
            else if (OutraResposta != null)
                OutraResposta.Responde(req, conta);
            else
              throw new Exception("Erro: Outra Resposta não informada");
        }
    }
}
