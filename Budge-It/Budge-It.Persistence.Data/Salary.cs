using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Budge_It.Persistence.Data
{
    public class Salary : EntityBase
    {
        [Required]
        public DateTime StartDateUtc { get; set; }

        [Required]
        [MaxLength(100)]
        public string Details { get; set; }
        
        [Required]
        public decimal Gross { get; set; }
        [Required]
        public decimal TakeHome { get; set; }

        [Required]
        public decimal GrossChange { get; set; }
        [Required]
        public decimal TakeHomeChange { get; set; }
        [Required]
        public decimal TakeHomePercentage { get; set; }

        [Required]
        public int CompanyId { get; set; }
        [ForeignKey(nameof(CompanyId))]
        public Company Company { get; set; }
    }
}
