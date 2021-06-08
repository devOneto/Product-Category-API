using System.ComponentModel.DataAnnotations;

namespace WebApiEF.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Esse campo é obrigatório.")]
        [MinLength(3,ErrorMessage = "O tamanho mínimo para esse campo é de três caracteres.")]
        [MaxLength(60,ErrorMessage = "O tamanho máximo para esse campo é de sessenta caracteres.")]
        public string Title { get; set; }
    }
}