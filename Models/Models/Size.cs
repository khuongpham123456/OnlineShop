﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class Size
    {
        [Key]
        public int SizeId { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}
