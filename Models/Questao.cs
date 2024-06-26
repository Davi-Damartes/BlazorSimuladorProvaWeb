using System.ComponentModel.DataAnnotations;

namespace BlazorSimuladorProva.Models
{
    public class Questao
    {
        [Required(ErrorMessage ="Campo Enunciado é obrigatório")]
        public string EnunciadoQuestao { get; set; } = string.Empty;
        public List<Alternativa> ListaAlternativas { get; set; } = new List<Alternativa>();
    }
}
