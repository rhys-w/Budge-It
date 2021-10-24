using System;

namespace Budge_It.BusinessLogic.Models.Interfaces
{
    public interface IAudited
    {
        DateTime CreatedOn { get; set; }
        DateTime LastModifiedOn { get; set; }
    }
}
