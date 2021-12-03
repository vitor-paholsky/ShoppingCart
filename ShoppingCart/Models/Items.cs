using ShoppingCart.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Items
    {
        public Guid IdCustomer { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        [MaxLength(80)]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Por favor, informe um e-mail válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor, informe o CPF")]
        [MaxLength(11)]
        public string Cpf { get; set; }
        [Required(ErrorMessage ="É obrigatório informar o nome do produto.")]
        [MaxLength(80)]
        public string Name { get; set; }
        [Required(ErrorMessage = "É obrigatório informar a descrição do produto.")]
        [MaxLength(1200)]
        public string Description { get; set; }
        [Required(ErrorMessage = "É obrigatório informar o preço do produto.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "É obrigatório informar a quantidade em estoque do produto.")]
        public int Stock { get; set; }           

        public Items()
        {
        }
    }
}
