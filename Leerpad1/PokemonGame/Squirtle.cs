using System;

public class Squirtle : Pokemon
{
    public Squirtle(string nickname) : base(nickname, "Water", "Leaf")
    {
    }

    public override void BattleCryShout()
    {
        Console.WriteLine($"{nickname}: Squirtle Squirtle!");
    }
}
