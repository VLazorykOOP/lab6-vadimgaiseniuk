namespace Lab6_Task_2;

public class Line : IFunction
{
    private double A { get; }
    private double B { get; }
    private double X { get; }

    public Line(double a, double b, double x) => (A, B, X) = (a, b, x);

    public double CalculateY()
    {
        Console.Write("Line: ");
        
        return A * X + B;
    }
}