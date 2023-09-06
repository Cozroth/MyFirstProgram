// Tobias Skog - .NET23
internal class Program
{
    static void Main(string[] args)
    {
        // Creating a new instance of random to decidie our number in this assignment
        Random rnd = new Random();
        // Creating our number with the rnd.Next method wich will return a number in the range of 0-20
        int randomInt = rnd.Next(0, 21);
        // If the randomInt is greater than 10 we will write to the console "Talet är stort!"
        if (randomInt > 10)
        {
            Console.WriteLine("Talet är stort!");
        }
        // if it's lower or equal to 10 we will instead write to the console "Oj. Lågt tal"
        else
        {
            Console.WriteLine("Oj. Lågt tal!");
        }
        // Asking the user for their name
        Console.WriteLine("Vad heter du?");
        // Creating a new string called 'name' and assigning that to the value the user writes in the console
        string name = Console.ReadLine();
        // String interpolation to reply to the user with "Hej {name}!" where {name} is the value of string name
        Console.WriteLine($"Hej {name}!");
        // For loop that writes the number 0 up to the value of randomInt, including the randomInt
        for (int i = 0; i <= randomInt; i++)
        {
            Console.WriteLine(i);
        }
    }
}
