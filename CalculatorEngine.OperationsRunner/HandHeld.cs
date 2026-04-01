public class HandHeld : Machine
{
    public double Weight { get; set; }

    public HandHeld(DateOnly serviceDate, double effect, double weight)
        : base(serviceDate, effect)
    {
        Weight = weight;
    }

    public override string BookService()
    {
        return "Service booked";
    }

    public override string Operate()
    {
        return "HandHeld machine is operating with battery mode.";
    }
}

