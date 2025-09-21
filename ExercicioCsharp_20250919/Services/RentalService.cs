using ExercicioCsharp_20250919.Entities;

namespace ExercicioCsharp_20250919.Services;

public class RentalService
{
    public double PricePerHour { get; set; }
    public double PricePerDay { get; set; }

    public RentalService()
    {
    }

    public RentalService(double pricePerHour, double pricePerDay)
    {
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
    }

    public void processInvoice(CarRental carRental)
    {
        
    }
}