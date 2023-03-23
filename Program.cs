
using System.Linq;


namespace MyApp // Note: actual namespace depends on the project name.
{ 

    class Program
    {
        static void Main(string[] args)

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
           
        
        Console.WriteLine("-- Welcome to your very own Pokemon Adventure!--");
            Console.WriteLine("-- What is your name? --");
            string playerName = Console.ReadLine();

            Console.WriteLine("Your name is " + playerName + "!");

            Console.WriteLine("What would you like to name your pokemon?");
            string pokeName = Console.ReadLine();
            Console.WriteLine("your pokemon's name is " + pokeName + "!");




            int playerhealth = 20;
            int enemyhealth = 20;

            while (playerhealth > -1 && enemyhealth > -1)
            {
                Console.WriteLine("The " + " has " + playerhealth + " health");
                Console.WriteLine("The " + oMon + " has" + enemyhealth + " health");
                Console.WriteLine("press 1 to attack, or 2 to heal");
                string choice = Console.ReadLine();
                int enemydamage = new Random().Next(1, 4);

                if (choice == "1")
                {
                    Console.WriteLine("You attacked for 2 damage");
                    enemyhealth -= 2;
                    Console.WriteLine("The " + oMon+ " attacked for " + enemydamage + " Damage!");
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
}