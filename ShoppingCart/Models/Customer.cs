using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Customer
    {
        [Key]
        public Guid IdCustomer { get; set; }
        [Required(ErrorMessage = "Por favor, informe seu nome.")]
        [MaxLength(80)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Por favor, informe um e-mail válido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Por favor, informe o CPF")]
        [MaxLength(11)]
        public string Cpf { get; set; }

        public Customer()
        {
        }
    }
}
