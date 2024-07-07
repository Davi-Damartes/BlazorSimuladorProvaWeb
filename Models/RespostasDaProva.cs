using BlazorSimuladorProva.Enum;

namespace BlazorSimuladorProva.Models
{
    public class RespostasDaProva
    {
        public int NumeroPergunta { get; set; } 

        public bool AcertouPergunta { get; set; }

        public EOpcaoAlternativa RespostaSelecionada { get; set; }
    }

}
