using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMvc.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Título")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O campo {0} deve ser preenchido")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime,ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data Lançamento")]
        public DateTime DataLancamento { get; set; }

        public string Genero { get; set; }

        [Range(0,1000,ErrorMessage = "Valor entre 0 e 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        public int Avaliacao { get; set; }
    }
}





