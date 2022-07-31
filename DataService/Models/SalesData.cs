using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Project_PRG281.DataService.Models
{
    [Table("Sales")]
    class SalesData
    {
        [Key]
        [Required]
        public int SalesID { get; set; }

        [Required]
        public int ProductID { get; set; }

        [Required]
        public int UserID { get; set; }
    }
}
