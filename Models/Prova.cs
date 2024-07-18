using BlazorSimuladorProva.Enum;
using System.ComponentModel.DataAnnotations;

namespace BlazorSimuladorProva.Models
{
    public class Prova
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MaxLength(100, ErrorMessage = "Nome deve ter no máximo 150 caracteres")]
        public string NomeProfessor { get; set; } = string.Empty;

        [Required(ErrorMessage = "Campo Quantidade de Alunos é obrigatório==========")]
        [Range(5, 30, ErrorMessage = "Número de 5 a 30 Alunos")]
        public int QuantidadeAlunos { get; set; }

        public ETipoProva TipoProva { get; set; }

        [Required(ErrorMessage = "Campo Quantidade Perguntas é obrigatório==========")]
        [Range(3, 5, ErrorMessage = "Número de 3 a 5 Perguntas")]
        public int QuantidadePerguntas { get; set; }

        public int QuantidadeAcertos { get; set; }

        public bool PerguntasCriadas { get; set; }
        public bool ProvaCriada { get; set; }
        public bool ProvaFinalizada { get; set; }

        public DateTime HoraEnvio { get; set; }
        public List<Pergunta> Perguntas { get; set; } = new List<Pergunta>();

        public List<int> AlternativasCorretas { get; set; } = new List<int>();
    }
}
