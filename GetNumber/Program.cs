using System;
using System.Text.Json.Serialization.Metadata;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Введiть цiле число: ");
        string userInput = Console.ReadLine();
        int result = 0;

        if (int.TryParse(userInput, out result))
        { 
            Console.WriteLine($"Ви ввели {result}");
        } 
        else
        {
            Console.WriteLine("Ви ввели не цiле число!");
        }
    }
}