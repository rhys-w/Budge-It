using System;

namespace Budge_It.BusinessLogic.Models
{
    public abstract class CompanyBase
    {
        public string Name { get; set; }
        public DateTime StartDateUtc { get; set; }
        public DateTime? EndDateUtc { get; set; }
    }
}