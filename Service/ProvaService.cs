using BlazorSimuladorProva.Models;

namespace BlazorSimuladorProva.Service
{
    public class ProvaService
    {
        public Prova ProvaInstancia { get; set; } = new();
        public int PerguntaAtual { get; set; } = 0;

    }
}
