
using System;
namespace MyApp;

class Program {


    static void Main(string[] args)
    {

        Header.pokeheader();
        StartGame.start();

        bool restart = true;
        while (restart)
        {
            
            CharacterCreate.create();
            Combat.combat();

            Console.WriteLine("Press 1 to play again or 2 to quit");
            string choice = Console.ReadLine();

            if (choice == "2")
            {
                restart = false;
            }
        }
    }
}