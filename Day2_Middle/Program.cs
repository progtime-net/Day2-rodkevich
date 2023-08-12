internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("What's your age?");
        var age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your age is {age}!");
    }
}