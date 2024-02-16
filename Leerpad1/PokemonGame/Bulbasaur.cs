using System;

public class Bulbasaur : Pokemon
{
    public Bulbasaur(string nickname) : base(nickname, PokemonType.Grass, PokemonType.Fire)
    {
        Console.WriteLine($"{Nickname}: Bulba-saur!");
    }
}