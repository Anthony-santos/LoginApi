using System.ComponentModel.DataAnnotations;
namespace WebApi.Models
{
    public class Usuario
    {
        [Key]
        public int Id { set; get; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]
        [MaxLength(50, ErrorMessage = "Este campo deve conter no máximo 50 caracteres")]
        public string Nome { set; get; }

        [Required(ErrorMessage = "Este campo é obrigatorio")]   
        public string Email { set; get; }
        
        [Required(ErrorMessage = "Este campo é obrigatorio")]
        public string senha { set; get; }
    }
}