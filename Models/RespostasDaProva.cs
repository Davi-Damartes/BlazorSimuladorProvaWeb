using BlazorSimuladorProva.Enum;

namespace BlazorSimuladorProva.Models
{
    public class RespostasDaProva
    {
        public List<int> NumeroPergunta { get; set; } = new List<int>();

        public int QntAcertos { get; set; } = 0;

        public List<bool> Acertou { get; set; } = new List<bool>();

        public List<Pergunta> PerguntasCertas { get; set; } = new List<Pergunta>();

        public EOpcaoAlternativa RespostaSelecionada { get; set; }
    }
}
