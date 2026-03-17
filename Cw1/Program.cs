namespace Cw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, User!");
            Console.Write("Please input a number for the first value: ");
            double firstValue = double.Parse(Console.ReadLine());
            Console.Write("Please input a number for the second value: ");
            double secondValue = double.Parse(Console.ReadLine());
            Console.Write("Please input an operator(+,-,/,*,^,%): ");
            string op = Console.ReadLine();
            Calc c = new Calc(firstValue, secondValue);
            Console.WriteLine("Results: "+c.Calculate(op));
        }
    }
}