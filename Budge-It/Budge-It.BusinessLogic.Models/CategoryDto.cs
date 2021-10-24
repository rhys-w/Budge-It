using Budge_It.BusinessLogic.Models.Interfaces;
using System;

namespace Budge_It.BusinessLogic.Models
{
    public class CategoryDto : CategoryBase, IAudited
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}