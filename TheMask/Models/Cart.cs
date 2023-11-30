namespace TheMask.Models
{
    public class Cart
    {
        public int ProductId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ProductOrdered { get; set; }

        public int ProductQuantity {get; set; }

        public float ProductPrice { get; set; }

        public float TotalPrice { get; set; }
        public DateTime Date { get; set; }

    }
}
