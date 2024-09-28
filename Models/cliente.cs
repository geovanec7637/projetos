using System.ComponentModel.DataAnnotations;

namespace cadastrocli.Models
{
    public class Cliente
    {
        [Key]
        [Required]
        [MaxLength(11, ErrorMessage = "O CPF deve ter no máximo 11 dígitos.")]
        [MinLength(11, ErrorMessage = "O CPF deve ter no mínimo 11 dígitos.")]
        public string Cpf { get; set; }

        [Required]
        [Display(Name = "Cliente")]
        [MaxLength(255, ErrorMessage = "O nome deve ter no máximo 255 caracteres.")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Telefone")]
        [MaxLength(15, ErrorMessage = "O telefone deve ter no máximo 15 caracteres.")]
        public string Telefone { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "O email inserido não é válido.")]
        public string Email { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "A cidade deve ter no máximo 100 caracteres.")]
        public string Cidade { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "A rua deve ter no máximo 100 caracteres.")]
        public string Rua { get; set; }

        [Required]  // Agora Bairro é obrigatório
        [MaxLength(100, ErrorMessage = "O bairro deve ter no máximo 100 caracteres.")]
        public string Bairro { get; set; }  // Agora não permite valor nulo

        [Required]
        [MaxLength(2, ErrorMessage = "O estado deve ter no máximo 2 caracteres.")]
        public string Estado { get; set; }
    }
}

