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
        switch (operation)
        {
            case "+":
                return a + b;
            case "-":
                return a - b;
            case "*":
                return a * b;
            case "/":
                return a / b;
            case "^":
                return Math.Pow(a, b);
            case "%":
                return a % b;
        }
        return 0;
    }

    public double CalculateAverage()
    {
        return (a + b)/2;
    }
}