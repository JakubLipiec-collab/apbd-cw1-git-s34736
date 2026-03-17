namespace Cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cw1.Calculator!");
            Console.Write("Please input a number for the first value: ");
            double firstValue = double.Parse(Console.ReadLine());
            Console.Write("Please input a number for the second value: ");
            double secondValue = double.Parse(Console.ReadLine());
            Console.Write("Please input an operator(+,-,/,*,^,%,avg,max): ");
            string op = Console.ReadLine();
            Calc c = new Calc(firstValue, secondValue);
            Console.WriteLine("Results: "+c.Calculate(op));
            Console.WriteLine("\nThank you for using this app! Goodbye");
        }
    }
}