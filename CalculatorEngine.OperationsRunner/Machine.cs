public class Machine
{
    public DateOnly ServiceDate { get; set; }
    public double Effect { get; set; }

    public Machine(DateOnly serviceDate, double effect)
    {
        ServiceDate = serviceDate;
        Effect = effect;
    }

    public string BookService()
    {
        return "Manager needs to approve";
    }
}