using ExercicioCsharp_20250919.Entities;

namespace ExercicioCsharp_20250919.Services;

public class OrderService
{
    private EmailService emailService = new EmailService();
    
    public OrderService()
    {
    }

    public void save(Order order)
    {
        
    }

    public List<Order> search(DateTime minDate, DateTime maxDate)
    {
        return null;
    }
}