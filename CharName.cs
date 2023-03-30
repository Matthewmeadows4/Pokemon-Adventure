using System;
using MyApp;

namespace MyApp;

public class CharName
{
    public static string name()
    {
        Charizard myCharizard = new Charizard();
        Console.WriteLine("I see that Professor Oak has given you a fully evolved Charizard, a " + myCharizard.Type + " Pokemon!");

        Console.WriteLine("What is your new Charizard's Name?");
        
        string name = Console.ReadLine();
        myCharizard.Name = name;
        Console.WriteLine(myCharizard.Name + "?... Excellent Choice!");

        return myCharizard.Name;
      

    }
}


