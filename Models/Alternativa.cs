using BlazorSimuladorProva.Enum;
using System.ComponentModel.DataAnnotations;

namespace BlazorSimuladorProva.Models
{
    public class Alternativa
    {
        [Required(ErrorMessage = "Campo Alternativa é obrigatório")]
        [StringLength(400, ErrorMessage = "Número máximo de caracteres 400")]
        public string TextoDasAlternativa { get; set; } = string.Empty;

        public bool IsCorreta { get; set; }

        public bool AlternativaAdicionada { get; set; }

        public EOpcaoAlternativa OpcaoAlternativa { get; set; }
    }
}
