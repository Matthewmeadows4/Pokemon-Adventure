using System;
using static MyApp.CharacterCreate;

namespace MyApp;

public class CharacterCreate
{

    public static void create()
    {
        Console.WriteLine("-- Welcome to your very own Pokemon Adventure!--");
        Console.WriteLine("-- What is your name? --");
        string playerName = Console.ReadLine();

        Console.WriteLine("Your name is " + playerName + "!");


    }
}