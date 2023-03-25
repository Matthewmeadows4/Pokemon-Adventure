using System;
namespace MyApp;

	public class CharacterCreate
	{
		public CharacterCreate()
		{
        Console.WriteLine("-- Welcome to your very own Pokemon Adventure!--");
        Console.WriteLine("-- What is your name? --");
        string playerName = Console.ReadLine();

        Console.WriteLine("Your name is " + playerName + "!");

        Console.WriteLine("What would you like to name your pokemon?");
        string pokeName = Console.ReadLine();
        Console.WriteLine("your pokemon's name is " + pokeName + "!");
    }
	}

