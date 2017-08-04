using System;

namespace CursoDesignPatterns.Investimentos
{
    public class Conta
    {
        public string Titular { get; set; }
        public string Agencia { get; set; }
        public string NumeroConta { get; set; }
        public double Saldo { get; set; }
        public DateTime DataAbertura { get; set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public Conta(string titular, string agencia, string numeroConta, double saldoInicial)
        {
            Titular = titular;
            Agencia = agencia;
            NumeroConta = numeroConta;
            Saldo = saldoInicial;
        }
    }
}
