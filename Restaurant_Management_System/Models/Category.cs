namespace Restaurant_Management_System.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
