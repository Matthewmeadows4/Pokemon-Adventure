using System;
using MyApp;

namespace MyApp;

public class CharName
{
    public static string name()
    {
        Console.WriteLine("I see that Professor Oak has given you a fully evolved Charizard!");

        Console.WriteLine("What is your new Charizard's Name?");
        Charizard charizard = new Charizard();
        string name = Console.ReadLine();
        charizard.Name = name;
        Console.WriteLine(charizard.Name + "?... Excellent Choice!");
        return charizard.Name;

    }
}


