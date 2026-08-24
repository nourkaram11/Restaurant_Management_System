using Microsoft.AspNetCore.Mvc;
using Restaurant_Management_System.Models;
using Restaurant_Management_System.Repositories;

using RestaurantManagementSystem.ViewModels;

namespace RestaurantManagementSystem.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMenuItemRepository _menuItemRepository;

        public OrderController(
            IOrderRepository orderRepository,
            IMenuItemRepository menuItemRepository)
        {
            _orderRepository = orderRepository;
            _menuItemRepository = menuItemRepository;
        }

        public IActionResult Index()
        {
            var orders = _orderRepository.GetAll();

            return View(orders);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var viewModel = new OrderCreateViewModel
            {
                MenuItems = _menuItemRepository.GetAll()
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(OrderCreateViewModel viewModel)
        {
            var order = new Order
            {
                Quantity = viewModel.Quantity,
                MenuItemId = viewModel.MenuItemId,
                OrderDate = DateTime.Now
            };

            _orderRepository.Add(order);

            return RedirectToAction("Index");
        }
    }
}