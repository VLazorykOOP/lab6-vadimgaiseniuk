namespace Lab6_Task_2;

public class Hyperbola : IFunction
{
    private double K { get; }
    private double X { get; }

    public Hyperbola(double k, double x) => (K, X) = (k, x);
    
    public double CalculateY()
    {
        Console.Write("Hyperbola: ");
        
        return K / X;
    }
}