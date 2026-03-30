using CalculatorEngine.Operations;

var operations = new List<IOperation>
{
    new AddOperation(),
    new MultiplyOperation()
};

foreach (var op in operations)
{
    Console.WriteLine(op.Execute(2, 3));
}