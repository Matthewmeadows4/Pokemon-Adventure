
using System.Linq;
using System;
namespace MyApp;



class Program

{
    static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Pokemone Adventure! would you like to begin?");
        Console.WriteLine("Enter 1 to start, or 2 to quit (use CNTRL + C to exit anytime.)");

        bool restart = true;
        while (restart)
        {

            CharacterCreate characterCreate = new CharacterCreate();
            Combat combat = new Combat();

            Console.WriteLine("Press 1 to play again or 2 to quit");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                restart = false;
            }
        }
    }
}