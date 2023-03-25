using System;
namespace MyApp;
public class Pokemon
{
   
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
