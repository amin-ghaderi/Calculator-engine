public class HandHeld : Machine
{
    public double Weight { get; set; }

    public HandHeld(DateOnly serviceDate, double effect, double weight)
        : base(serviceDate, effect)
    {
        Weight = weight;
    }

    public new string BookService()
    {
        return "Service booked";
    }
}