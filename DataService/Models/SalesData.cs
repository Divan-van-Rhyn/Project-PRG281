using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project_PRG281.DataService.Models
{
    [Table("Sales")]
    public class SalesData
    {
        [Key]
        [Required]
        public int SalesID { get; set; }

        [Required]
        public int ProductID { get; set; }

        public ProductData Product { get; set; }

        [Required]
        public int UserID { get; set; }

        public LoginData User { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}
