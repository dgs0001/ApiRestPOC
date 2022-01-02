using System;
using System.ComponentModel.DataAnnotations;

namespace AR.Domain
{
    public class Cliente
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O campo deve conter no máximo {1} caracteres")]
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Idade { get; set; }

    }
}
