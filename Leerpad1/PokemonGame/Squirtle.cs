using System;

public class Squirtle : Pokemon
{
    public Squirtle(string nickname) : base(nickname, "Water", "Grass")
    {
    }

    public override void BattleCryShout()
    {
        Console.WriteLine($"{nickname}: Squirtle Squirtle!");
    }
}