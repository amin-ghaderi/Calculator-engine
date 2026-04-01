using CalculatorEngine.Operations;


//2026-04-01 polymorphism exercise
var machines = new List<Machine>
{
    new HandHeld(DateOnly.FromDateTime(DateTime.Now), 0.92, 1.2),
    new Embedded(DateOnly.FromDateTime(DateTime.Now), 0.88, "Industrial")
};

foreach (var machine in machines)
{
    if (machine is HandHeld)
    {
        Console.WriteLine("This is a HandHeld machine.");
    }
    else if (machine is Embedded embedded)
    {
        Console.WriteLine($"This is an Embedded machine. Context: {embedded.Context}");
    }
}

foreach (var machine in machines)
{
    Console.WriteLine(machine.Operate());
}

//2026-03-31 inharitance exercise

var handHeld = new HandHeld(DateOnly.FromDateTime(DateTime.Now), 0.9, 1.5);

Console.WriteLine(handHeld.BookService());





//2026-03-30interface IOperation 

var operations = new List<IOperation>
{
    new AddOperation(),
    new MultiplyOperation()
};

foreach (var op in operations)
{
    Console.WriteLine(op.Execute(2, 3));
}



