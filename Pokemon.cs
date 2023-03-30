using System;
namespace MyApp;
public class Pokemon
{
    public string Type;
    public string Name { get; set; }
    public virtual string roar()
    {
        return "Pokemon Roar";
    }
}

public class Charizard : Pokemon
{
    public string Type = "Fire";
    public string Name = "";
    public override string roar()
    {
        return "GRRRRRRRRRRROO!";
    }
}
