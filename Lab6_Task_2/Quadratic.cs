namespace Lab6_Task_2;

public class Quadratic : IFunction
{
    private double A { get; }
    private double B { get; }
    private double C { get; }
    private double X { get; }

    public Quadratic(double a, double b, double c, double x) => (A, B, C, X) = (a, b, c, x);
    
    public double CalculateY()
    {
        Console.Write("Quadratic: ");
        
        return Math.Pow(A * X, 2) + B * X + C;
    }
}