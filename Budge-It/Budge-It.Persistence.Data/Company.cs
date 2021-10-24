using System;
using System.ComponentModel.DataAnnotations;

namespace Budge_It.Persistence.Data
{
    public class Company : EntityBase
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
    }
}
