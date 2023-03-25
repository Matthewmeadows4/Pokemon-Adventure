using System;
namespace MyApp;

public class Combat
{
    public Combat()
    {

        var Random = new Random();
        List<string> mons = new List<string>();

        mons.Add("Bulbasaur");
        mons.Add("Charizard");
        mons.Add("Squirtle");
        mons.Add("Pikachu");
        mons.Add("MewTwo");
        mons.Add("Eevee");
        mons.Add("Mew");
        mons.Add("Greninja");
        mons.Add("Snorlax");


        int index = Random.Next(mons.Count);
        string oMon = mons[index];

        int playerhealth = 20;
        int enemyhealth = 20;


        Console.WriteLine("-- I see that Professor Oak has given you a fully evolved Charizard!");

        Console.WriteLine("What is your new Charizard's Name?");
        string monName = Console.ReadLine();
        Console.WriteLine(monName + "?... Excellent Choice!");
        Console.WriteLine("-- You begin to walk down route 1, when all of the sudden, you are attacked by a wild" + oMon + "! You and " + monName + " look at each other, and agree... YOU'VE GOT THIS!--");



        while (playerhealth > -1 && enemyhealth > -1)
        {
            Console.WriteLine(monName + " has " + playerhealth + " health") ;
            Console.WriteLine("The " + oMon + " has " + enemyhealth + " health");
            Console.WriteLine("press 1 to attack, or 2 to heal");
            string choice = Console.ReadLine();
            int enemydamage = new Random().Next(1, 4);

            if (choice == "1")
            {
                Console.WriteLine("You attacked for 2 damage");
                enemyhealth -= 2;
                Console.WriteLine("The " + oMon + " attacked for " + enemydamage + " Damage!");
                playerhealth -= enemydamage;
            }
            if (choice == "2")
            {
                Console.WriteLine("You healed for " + enemydamage + "Health");
                Console.WriteLine("The" + oMon + " wouldve dealt " + enemydamage + " damage.");
                playerhealth += enemydamage;
            }
        }
    }
}
	