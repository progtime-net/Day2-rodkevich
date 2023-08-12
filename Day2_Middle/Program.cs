internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("What's your name?");
        var name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine("How old are you?");
        var age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your age is {age}!");
    }
}