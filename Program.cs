namespace Classes_Mangum_Stephen
{
    using System;

// Greetings class with two public methods
public class Greetings
{
    // Method to print a welcome message
    public void Welcome()
    {
        Console.WriteLine("You know...we had a Go Green assembly today...");
    }

    // Method to print a personalized message
    public void Hello(string name)
    {
        Console.WriteLine($"I don't think I saw YOU there, {name}...");
    }
}

// Program class with Main method
class Program
{
    static void Main(string[] args)
    {
        // Creates an instance of Greetings
        Greetings greetings = new Greetings();

        // Calls the Welcome method
        greetings.Welcome();

        // Calls the Hello method with a string argument
        greetings.Hello("Houston");
    }
}
}