namespace BlazorSimuladorProva.Models
{
    public class Pergunta
    {
        public string EnunciadoDaPergunta { get;set; } = string.Empty;
        public List<Questao> Questoes { get; set; } = new List<Questao>();

    }
}
