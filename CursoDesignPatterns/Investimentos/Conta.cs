namespace CursoDesignPatterns.Investimentos
{
    public class Conta
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void Deposita(double valor)
        {
            Saldo += valor;
        }

        public Conta(string titular, double saldoInicial)
        {
            Titular = titular;
            Saldo = saldoInicial;
        }
    }
}
