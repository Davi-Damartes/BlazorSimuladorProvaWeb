using System.ComponentModel.DataAnnotations;

namespace BlazorSimuladorProva.Models
{
    public class Aluno
    {
        [Required(ErrorMessage ="Campo Nome é obrigatório")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Email é obrigatório")]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

    }
}
