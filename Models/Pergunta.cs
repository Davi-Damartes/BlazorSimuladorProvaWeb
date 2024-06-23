namespace BlazorSimuladorProva.Models
{
    public class Pergunta
    {
        public string Imagem { get; set; } = string.Empty;
        public List<string> Questoes { get; set; } = new List<string>();

        public List<string> Respostas { get; set; } = new List<string>();
        public string RespostaCorreta { get; set; } = string.Empty;


    }
}
