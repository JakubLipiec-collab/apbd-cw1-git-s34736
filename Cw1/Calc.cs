namespace Cw1;

public class Calc
{
    private double a;
    private double b;
    public Calc(double a, double b)
    {
        this.a = a;
        this.b = b;
    }
    public double Calculate(string operation)
    {
        if (operation == "+")
        {
            return a + b;
        }
        if (operation == "-")
        {
            return a - b;
        }
        if (operation == "*")
        {
            return a * b;
        }
        if (operation == "/")
        {
            return a / b;
        }
        return 0;
    }
}