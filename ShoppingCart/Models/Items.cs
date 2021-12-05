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
        [Required(ErrorMessage = "Please, inform the name of the product.")]
        [MaxLength(80)]      
        public string Name { get; set; }
        [Required(ErrorMessage = "Please, inform the product description.")]
        [MaxLength(1200)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please, inform the product price.")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please, inform the quantity.")]
        public int Quantity { get; set; }
       
        public Guid? IdCustomer {get;set;}

        [NotMapped]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Total
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
