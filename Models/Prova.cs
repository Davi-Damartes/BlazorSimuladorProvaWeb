using BlazorSimuladorProva.Enum;

namespace BlazorSimuladorProva.Models
{
    public class Prova
    {
        public string NomeProfessor {  get; set; } = string.Empty;
        public int QuantiadadeAlunos {  get; set; } 
        public ETipoProva TipoProva {  get; set; }
        public int QuantidadePerguntas { get; set; }

        public DateTime HoraEnvio { get; set; }

        public List<Perguntas> Perguntas { get; set; } = new List<Perguntas>();
    }
}
