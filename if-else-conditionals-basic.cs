using System;

class Program
{
    static void Main()
    {
        Console.Write("Write your name: ");
        string name = Console.ReadLine();

        Console.Write("Write your age: ");
        int age = Convert.ToInt32(Console.ReadLine()); // Age is integer


        if (age >= 18)
        {
            Console.WriteLine($"Thank you! {name}, You can vote!");
        }
        else
        {
            Console.WriteLine($"Sorry {name}, You can't vote");
        }
    }
}
