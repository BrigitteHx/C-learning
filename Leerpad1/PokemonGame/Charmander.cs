using System;

public class Charmander : Pokemon
{
    public Charmander(string nickname) : base(nickname, "Fire", "Water")
    {
    }

    public override void BattleCryShout()
    {
        Console.WriteLine($"{nickname}: Charmander powerrr!");
    }
}
