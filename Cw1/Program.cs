namespace Cw1;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello user, please input your preferred name"); 
        Console.Write("Enter your name: ");
        string name = "";
        try
        {
            name = Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
        User u =  new User(name);
    }
}