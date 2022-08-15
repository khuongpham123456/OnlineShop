using Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [StringLength(50)]
        [Required]
        public string Username { get; set; }

        [StringLength(20)]
        [Required]
        public string Password { get; set; }

        [Required]
        public Active IsActive { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
