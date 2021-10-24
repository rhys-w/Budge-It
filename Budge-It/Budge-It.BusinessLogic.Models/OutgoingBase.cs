namespace Budge_It.BusinessLogic.Models
{
    public abstract class OutgoingBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberOfPayments { get; set; }
        public decimal PaymentValue { get; set; }
        public int CategoryId { get; set; }
    }
}
