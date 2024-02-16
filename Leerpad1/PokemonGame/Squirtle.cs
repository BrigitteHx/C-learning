using System;

public class Squirtle : Pokemon
{
    public Squirtle(string nickname) : base(nickname, PokemonType.Water, PokemonType.Grass)
    {
    }

    public override void BattleCryShout()
    {
        Console.WriteLine($"{Nickname}: Squirtle Squirtle!");
    }
}
