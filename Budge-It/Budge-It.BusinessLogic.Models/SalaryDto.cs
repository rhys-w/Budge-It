using Budge_It.BusinessLogic.Models.Interfaces;
using System;

namespace Budge_It.BusinessLogic.Models
{
    public class SalaryDto : SalaryBase, IAudited
    {
        public int Id { get; set; }
        public decimal GrossChange { get; set; }
        public decimal TakeHomeChange { get; set; }
        public decimal TakeHomePercentage { get; set; }

        public CompanyDto Company { get; set; }

        public DateTime CreatedOn { get; set; }
        public DateTime LastModifiedOn { get; set; }
    }
}
