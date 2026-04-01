public class Machine
{
    public DateOnly ServiceDate { get; set; }
    public double Effect { get; set; }

    public Machine(DateOnly serviceDate, double effect)
    {
        ServiceDate = serviceDate;
        Effect = effect;
    }

    public virtual string BookService()
    {
        return "Manager needs to approve";
    }

    public virtual string Operate()
    {
        return "Machine is operating.";
    }
}

