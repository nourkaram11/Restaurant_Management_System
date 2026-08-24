namespace Restaurant_Management_System.Models
{
    public class Order
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public DateTime OrderDate { get; set; }


        public int MenuItemId { get; set; }

        public MenuItem MenuItem { get; set; }
    }
}
