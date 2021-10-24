using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Budge_It.Persistence.Data
{
    public class Outgoing : EntityBase
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int NumberOfPayments { get; set; }
        [Required]
        public decimal PaymentValue { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; }
    }
}
