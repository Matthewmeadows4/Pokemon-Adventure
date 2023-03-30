using System;
namespace MyApp;
public class Pokemon
{
    public string Name { get; set;  }  
    public virtual string MakeSound()
    {
        return "Pokemon Roar";
    }
}

public class Charizard : Pokemon
{
    public override string MakeSound()
    {
        return "GRRRRRRRRRRROO!";
    }
}
