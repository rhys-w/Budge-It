using Budge_It.BusinessLogic.Models.Interfaces;
using System;

namespace Budge_It.BusinessLogic.Models
{
    public class OutgoingDto : OutgoingBase, IAudited
    {
        public int Id { get; set; }
        public decimal AnnualTotal { get; set; }

        public CategoryDto Category { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}