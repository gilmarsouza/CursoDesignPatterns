using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Investimentos.Respostas
{
    public class RespostaEmCsv: IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmCsv(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public RespostaEmCsv()
        {
            OutraResposta = null;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.Csv)
                Console.WriteLine("{0};{1}", conta.Titular, conta.Saldo);
            else if (OutraResposta != null)
                OutraResposta.Responde(req, conta);
            else
                throw new Exception("Erro: Outra Resposta não informada");
        }
    }
}
