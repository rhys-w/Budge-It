using System;

namespace Budge_It.BusinessLogic.Models
{
    public abstract class SalaryBase
    {
        public DateTime StartDateUtc { get; set; }
        public string Details { get; set; }
        public decimal Gross { get; set; }
        public decimal TakeHome { get; set; }

        public int CompanyId { get; set; }
    }
}
