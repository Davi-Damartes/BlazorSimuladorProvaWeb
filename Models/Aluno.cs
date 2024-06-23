using System.ComponentModel.DataAnnotations;

namespace BlazorSimuladorProva.Models
{
    public class Aluno
    {
        [Required]
        public string Nome { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

    }
}
