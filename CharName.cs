using System;
using MyApp;

namespace MyApp;

public class CharName
{
    public static string name()
    {
        Charizard charizard = new Charizard();
        Console.WriteLine("I see that Professor Oak has given you a fully evolved Charizard, a " + charizard.Type + " Pokemon!");

        Console.WriteLine("What is your new Charizard's Name?");
        
        string name = Console.ReadLine();
        charizard.Name = name;
        Console.WriteLine(charizard.Name + "?... Excellent Choice!");

        return charizard.Name;
      

    }
}


