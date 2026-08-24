using Restaurant_Management_System.Models;

namespace Restaurant_Management_System.Repositories
{
    public interface IOrderRepository
    {

        List<Order> GetAll();

        Order GetById(int id);

        void Add(Order order);
    }
}
