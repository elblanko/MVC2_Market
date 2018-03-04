using System;
using System.ComponentModel.DataAnnotations;

namespace MVC2_Market.Models
{
    public class Product
    {
        [Key]
        public int Id { set; get; }
        public string Description { get; set; }
        public decimal Price { set; get; }
        public DateTime LastBuy { set; get; }
        public int Stock { set; get; }
        public string Remmarks { get; set; }        
    }
}