using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class BillDetail
    {
        [Key]
        public int BillDetailId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,4)")]
        public decimal quantity { get; set; }

        public int BillId { get; set; }

        [ForeignKey("BillId")]
        [Required]
        public Bill Bill { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        [Required]
        public Product Product { get; set; }
    }
}
