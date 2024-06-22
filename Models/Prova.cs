using BlazorSimuladorProva.Enum;
using System.ComponentModel.DataAnnotations;

namespace BlazorSimuladorProva.Models
{
    public class Prova
    {
        [MaxLength(150, ErrorMessage ="Nome deve ter no máximo 150 caracteres")]
        public string NomeProfessor {  get; set; } = string.Empty;

        [MaxLength(30, ErrorMessage = "Quantida de Alunos deve ter no máximo 30")]
        public int QuantidadeAlunos {  get; set; } 

        public ETipoProva TipoProva {  get; set; }

        [MinLength(3, ErrorMessage = "Tem q ter no mínimo 3 pergutas")]
        [MaxLength(10, ErrorMessage = "Tem q ter no mínimo 10 pergutas")]
        public int QuantidadePerguntas { get; set; }

        public DateTime HoraEnvio { get; set; } = DateTime.Now;

        public List<Perguntas> Perguntas { get; set; } = new List<Perguntas>();
    }
}
