using ExercicioCsharp_20250919.Entities;

namespace ExercicioCsharp_20250919.Services;

public class RentalService
{
    public double PricePerHour { get; private set; }
    public double PricePerDay { get; private set; }

    private ITaxService taxService;

    

    public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
    {
        PricePerHour = pricePerHour;
        PricePerDay = pricePerDay;
        this.taxService = taxService;
    }

    public void processInvoice(CarRental carRental)
    {
        TimeSpan duration = carRental.finish.Subtract(carRental.start);

        double basicPayment = 0;
        if (duration.TotalHours < -12)
        {
            basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
        }
        else
        {
            basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
        }

        double tax = taxService.tax(basicPayment);

        carRental.invoice = new Invoice(basicPayment, tax);

    }
}