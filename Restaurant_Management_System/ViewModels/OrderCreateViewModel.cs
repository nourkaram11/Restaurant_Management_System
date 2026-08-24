using Restaurant_Management_System.Models;


namespace RestaurantManagementSystem.ViewModels
{
    public class OrderCreateViewModel
    {
        public int Quantity { get; set; }

        public int MenuItemId { get; set; }

        public List<MenuItem> MenuItems { get; set; }
    }
}