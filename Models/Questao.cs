using System.ComponentModel.DataAnnotations;

namespace BlazorSimuladorProva.Models
{
    public class Questao
    {
        [Required]
        public string Enunciado { get; set; } = string.Empty;
        public List<Alternativa> Alternativas { get; set; } = new List<Alternativa>();
    }
}
