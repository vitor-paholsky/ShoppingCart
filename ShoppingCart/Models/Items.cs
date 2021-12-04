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
        [Key]
        public Guid IdItem { get; set; }
        [Required(ErrorMessage = "Por favor, informe o nome do produto.")]
        [MaxLength(80)]      
        public string Name { get; set; }
        [Required(ErrorMessage = "É obrigatório informar a descrição do produto.")]
        [MaxLength(1200)]
        public string Description { get; set; }
        [Required(ErrorMessage = "É obrigatório informar o preço do produto.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "É obrigatório informar a quantidade em estoque do produto.")]
        public int Quantity { get; set; }
       
        public Guid? IdCustomer {get;set;}

        [NotMapped]
        public decimal valorTotal
        {
            get
            {
                return Price * Quantity;
            }
        }

        public Items()
        {
        }
    }
}
