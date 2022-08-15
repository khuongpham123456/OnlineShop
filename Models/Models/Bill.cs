using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }

        [Required]
        public DateTime CreateDate { get; set; }

        public int EmployeeId { get; set; }

        [ForeignKey("EmployeeId")]
        [Required]
        public Employee Employee { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        [Required]
        public Customer Customer { get; set; }
    }
}
