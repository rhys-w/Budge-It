using System;
using System.ComponentModel.DataAnnotations;

namespace Budge_It.Persistence.Data
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public DateTime LastModifiedOn { get; set; }
    }
}