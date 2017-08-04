using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CursoDesignPatterns.Interfaces;

namespace CursoDesignPatterns.Investimentos.Respostas
{
    public class RespostaEmXml: IResposta
    {
        public IResposta OutraResposta { get; set; }

        public RespostaEmXml(IResposta outraResposta)
        {
            OutraResposta = outraResposta;
        }

        public RespostaEmXml()
        {
            OutraResposta = null;
        }

        public void Responde(Requisicao req, Conta conta)
        {
            if (req.Formato == Formato.Xml)
                Console.WriteLine("<conta><titular>{0}</titular><saldo>{1}</saldo></conta>", conta.Titular, conta.Saldo);
            else if (OutraResposta != null)
                OutraResposta.Responde(req, conta);
            else
                throw new Exception("Erro: Outra Resposta não informada");
        }
    }
}
