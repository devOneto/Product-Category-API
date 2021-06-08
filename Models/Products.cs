using System.ComponentModel.DataAnnotations;

namespace WebApiEF.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Esse campo é obrigatório.")]
        [MinLength(3,ErrorMessage = "O tamanho mínimo para esse campo é de três caracteres.")]
        [MaxLength(60,ErrorMessage = "O tamanho máximo para esse campo é de sessenta caracteres.")]
        public string Title { get; set; }

        [MaxLength(1024,ErrorMessage = "A descrição deve ter até 1024 caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "É obrigatório informar o preço do produto.")]
        [Range(1,int.MaxValue,ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Range(1,int.MaxValue, ErrorMessage = "Categoria inexistente.")]
        public int CategoryId { get; set; }
        public Category Category {get; set;}
    }
}