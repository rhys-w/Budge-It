using System.ComponentModel.DataAnnotations;

namespace Budge_It.Persistence.Data
{
    public class Category : EntityBase
    {
        [Required]
        public string Name { get; set; }
    }
}
