using Restaurant_Management_System.Data;
using Restaurant_Management_System.Models;

namespace Restaurant_Management_System.Repositories
{
    public class MenuItemRepository : IMenuItemRepository
    {
        private readonly AppDbContext _context;
        public MenuItemRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(MenuItem menuItem)
        {
           _context.MenuItems.Add(menuItem);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var menuItem = _context.MenuItems.FirstOrDefault(x => x.Id == id);

            if (menuItem != null)
            {
                _context.MenuItems.Remove(menuItem);
                _context.SaveChanges();
            }
        }

        public List<MenuItem> GetAll()
        {
            return _context.MenuItems.ToList();
        }

        public MenuItem GetById(int id)
        {
            return _context.MenuItems.FirstOrDefault(m => m.Id == id);
        }

        public void Update(MenuItem menuItem)
        {
            _context.MenuItems.Update(menuItem);
            _context.SaveChanges();
        }
    }
}
