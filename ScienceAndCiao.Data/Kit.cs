﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceAndCiao.Data
{
    public class Kit
    {
        [Required]
        [Index(IsUnique = true)]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Ingredients { get; set; }
        public int LengthMinutes { get; set; }

        [Required]
        public byte BranchId { get; set; }
        [ForeignKey(nameof(BranchId))]
        public virtual Branch Branch { get; set; }
        [Range(1, 2000)]
        public DateTime DateAdded { get; set; }
    }

        

    }
