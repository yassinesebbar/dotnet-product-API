using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace coolblue_assesment.Models
{
    public class ProductType
    {
        [Key]
        private int id { get; set; }

        [Required]
        private string name { get; set; }

        [Required]
        private bool canBeInsured { get; set; }

        public List<Product> Products {get; set;}
    }
}