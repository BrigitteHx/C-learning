using System;

public class Bulbasaur : Pokemon
{
    public Bulbasaur(string nickname) : base(nickname, "Grass", "Fire")
    {
    }

    public override void BattleCryShout()
    {
        Console.WriteLine($"{nickname}: Bulba-saur!");
    }
}