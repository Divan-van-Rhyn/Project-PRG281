using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project_PRG281.DataService.Models
{
    [Table("Product")]
    public class ProductData
    {
        [Key]
        [Required]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(100)]
        public string Product { get; set; }

        [Required]
        public double Price { get; set; }

        public ICollection<SalesData> Sales { get; set; }
    }
}
