namespace ExercicioCsharp_20250919.Services;

public class OrderRepository : crudRepository<DateTime, int>
{
    private OrderService repo = new OrderService();
    
    public OrderRepository()
    {
    }

    public DateTime save(DateTime obj)
    {
        throw new NotImplementedException();
    }

    public void delete(DateTime obj)
    {
        throw new NotImplementedException();
    }

    public DateTime findById(int id)
    {
        throw new NotImplementedException();
    }

    public List<DateTime> findAll()
    {
        throw new NotImplementedException();
    }
}