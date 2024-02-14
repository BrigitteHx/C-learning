using System;

public class Bulbasaur : Pokemon
{
    public Bulbasaur(string nickname) : base(nickname, PokemonType.Grass, PokemonType.Fire)
    {
    }

    public override void BattleCryShout()
    {
        Console.WriteLine($"{Nickname}: Bulba-saur!");
    }
}
