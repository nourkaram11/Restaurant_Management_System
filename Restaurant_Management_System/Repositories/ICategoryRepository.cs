using Restaurant_Management_System.Models;

namespace Restaurant_Management_System.Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category GetById(int id);
        void Add(Category category);
    }
}
