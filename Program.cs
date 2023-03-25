
using System.Linq;
using System;
namespace MyApp;



class Program

{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Pokemone Adventure! would you like to begin?");
        Console.WriteLine("Enter 1 to start, or 2 to quit (use CNTRL + C to exit anytime.)");
        string choice;
        while ((choice = Console.ReadLine()) != "2")
        {

            CharacterCreate characterCreate = new CharacterCreate();

            Combat combat = new Combat();

  
        }

    }
}