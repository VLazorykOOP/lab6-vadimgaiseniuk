namespace Lab6_Task_2;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the X value: ");
        var x = Convert.ToDouble(Console.ReadLine());
        
        List<IFunction> functions = new List<IFunction>();
        
        functions.Add(new Line(-3, 5, x));
        functions.Add(new Quadratic(4, -3, 2, x));
        functions.Add(new Hyperbola(5, x));

        foreach (var function in functions)
        {
            Console.WriteLine(function.CalculateY());
        }
    }
}