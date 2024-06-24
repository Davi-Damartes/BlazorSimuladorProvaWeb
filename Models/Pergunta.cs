namespace BlazorSimuladorProva.Models
{
    public class Pergunta
    {
        public string Imagem { get; set; } = string.Empty;
        public List<Questao> Questoes { get; set; } = new List<Questao>();
        public string Texto { get; set; } = string.Empty;


    }
}
