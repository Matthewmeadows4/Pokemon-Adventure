using System;
namespace MyApp;

public class Combat
{
    public static void combat()
    {
       string name = CharName.name();

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
            int enemyhealth = 30;


        Console.WriteLine("You begin to walk down route 1, when all of the sudden, you are attacked by a wild " + oMon + "! You and " + name + " look at each other, and agree... YOU'VE GOT THIS!");

        Charizard charizard = new Charizard();


        string sound = charizard.roar();

        Console.WriteLine(name + " Is ready for battle! As you begin to prepare, they let out a loud " + charizard.roar());

     
        while (playerhealth > 0 && enemyhealth > 0)

        {


            Console.WriteLine(name + " has " + playerhealth + " health");
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
                Console.WriteLine("You healed for " + enemydamage + " Health");
                Console.WriteLine("The " + oMon + " wouldve dealt " + enemydamage + " damage.") ;
                playerhealth += enemydamage;
            }

            if(playerhealth > 25)
            {
                Console.WriteLine("You have reached max health!");
                playerhealth = 25;
            }

            if (choice != "1" && choice != "2")
            {
                Console.WriteLine("That's not right! Enter 1 to attack or 2 to heal.");
            }
            if (playerhealth <= 0)
            {
                Console.WriteLine("Oh no! " + name + " has fainted! You rush to the nearst Pokemon center to take care of your friend.");
            }
            if (enemyhealth <= 0)
            {
                Console.WriteLine("Wow! You and " + name + " did it! You make a great team!");
                int VictoryCalc = Margain_Calculator.MargCalc(playerhealth, enemyhealth);
                Console.WriteLine("You won by " + VictoryCalc + " Points!");
            }
        }
    }
}
	