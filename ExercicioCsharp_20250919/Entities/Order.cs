namespace ExercicioCsharp_20250919.Entities;
using ExercicioCsharp_20250919.Entities.Enums;

public class Order
{
    public DateTime moment { get; set; }
    public OrderStatus status { get; set; }

    public Client client { get; set; }
    public List<OrderItem> items = new List<OrderItem>();

    public Order()
    {
    }

    public Order(DateTime moment, OrderStatus status, Client client)
    {
        this.moment = moment;
        this.status = status;
        this.client = client;
    }

    public void addItem(OrderItem item)
    {
        items.Add(item);
    }
    
    public void removeItem(OrderItem item)
    {
        items.Remove(item);
    }

    public double total()
    {
        return 0;
    }
    
}