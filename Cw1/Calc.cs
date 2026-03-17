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
            case "avg":
                return CalculateAverage();
            case "max":
                return CalculateMax();
            case "min":
                return CalculateMin();
        }
        return 0;
    }

    private double CalculateAverage()
    {
        return (a + b)/2;
    }
    
    private double CalculateMax(){
        return Math.Max(a, b);
    }
    
    private double CalculateMin()
    {
        return Math.Min(a, b);
    }
}