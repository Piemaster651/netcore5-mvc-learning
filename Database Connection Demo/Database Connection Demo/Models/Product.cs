using System;
using System.ComponentModel.DataAnnotations;

namespace Database_Connection_Demo.Models
{
    // POCO
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
    }
}