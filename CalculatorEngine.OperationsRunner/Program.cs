using CalculatorEngine.Operations;


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



