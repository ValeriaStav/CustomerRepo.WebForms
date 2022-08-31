namespace CustomerManagement.BusinessEntities
{
    public class Customer
    {

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerEmail { get; set; }
        public decimal TotalPurchaseAmount { get; set; }

    }
}
