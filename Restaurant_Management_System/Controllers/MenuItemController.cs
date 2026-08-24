using Microsoft.AspNetCore.Mvc;
using Restaurant_Management_System.Models;
using Restaurant_Management_System.Repositories;


namespace Restaurant_Management_System.Controllers
{
    public class MenuItemController : Controller
    {
        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemController(IMenuItemRepository menuItemRepository)
        {
            _menuItemRepository = menuItemRepository;
        }

        public IActionResult Index()
        {
            var menuItems = _menuItemRepository.GetAll();

            return View(menuItems);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MenuItem menuItem)
        {
            

            _menuItemRepository.Add(menuItem);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var menuItem = _menuItemRepository.GetById(id);

            if (menuItem == null)
            {
                return NotFound();
            }

            return View(menuItem);
        }

        [HttpPost]
        public IActionResult Edit(MenuItem menuItem)
        {
            _menuItemRepository.Update(menuItem);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _menuItemRepository.Delete(id);

            return RedirectToAction("Index");
        }
    }
}