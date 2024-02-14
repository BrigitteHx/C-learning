using System;

public class Charmander : Pokemon
{
    public Charmander(string nickname) : base(nickname, PokemonType.Fire, PokemonType.Water)
    {
    }

    public override void BattleCryShout()
    {
        Console.WriteLine($"{Nickname}: Charmander powerrr!");
    }
}
