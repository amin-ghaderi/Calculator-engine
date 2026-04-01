public class Embedded : Machine
{
    public string Context { get; set; }

    public Embedded(DateOnly serviceDate, double effect, string context)
        : base(serviceDate, effect)
    {
        Context = context;
    }

    public override string Operate()
    {
        return $"Embedded machine is operating in {Context} context.";
    }
}
