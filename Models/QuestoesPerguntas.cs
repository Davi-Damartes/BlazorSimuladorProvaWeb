namespace BlazorSimuladorProva.Models
{
    public class QuestoesPerguntas
    {
        public string Imagem {  get; set; } = string.Empty;

        public List<string> Questoes = new List<string>();

        public bool RespostaCorreta { get;set; } = false;

    }
}