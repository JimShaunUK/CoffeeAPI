using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeAPI.Models
{
    public class Products
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }
        public string Description { get; set; }



    }
}
