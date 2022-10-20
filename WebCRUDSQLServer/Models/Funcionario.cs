using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebCRUDSQLServer.Models
{
    [Table("Funcionario")] 
    public class Funcionario
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Nome é obrigatorio.", AllowEmptyStrings = false)]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Atenção! O campo nome deve ter entre 3 e 100 caracteres. ") ]
        [Column("Nome")]
        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Salario é obrigatorio.", AllowEmptyStrings = false)]
        [Column("Salário")]
        [Display(Name = "Salário")]
        public double Salario { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Data é obrigatoria.", AllowEmptyStrings = false)]
        [Column("Admissão")]
        [Display(Name = "Admissão")]
        public DateTime Admissao { get; set; }

        [Required(ErrorMessage = "Atenção! O campo Ativo é obrigatoria.", AllowEmptyStrings = false)]
        [Column("Ativo")]
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        [Required(ErrorMessage = "Atenção! Digite campo M para Masculino e F para Feminina.", AllowEmptyStrings = false)]
        [Column("Genero")]
        [Display(Name = "Genero")]
        public char Genero { get; set; }

    }
}
