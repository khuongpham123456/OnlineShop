using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }

        [StringLength(50)]
        [Required]
        public string Fullname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string? Address { get; set; }

        public int AccountId { get; set; }
       
        [Required]
        [ForeignKey("AccountId")]
        public Account Account { get; set; }
    }
}
