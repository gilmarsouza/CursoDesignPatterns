namespace CursoDesignPatterns.Investimentos
{
    public class Requisicao
    {
        public Formato Formato { get; set; }

        public Requisicao(Formato formato)
        {
            Formato = formato;
        }
    }

    public enum Formato
    {
        Xml, Csv, Porcento
    }
}
