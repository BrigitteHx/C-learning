using System;

public class Squirtle : Pokemon
{
    public Squirtle(string nickname) : base(nickname, PokemonType.Water, PokemonType.Grass)
    {
        Console.WriteLine($"{Nickname}: Squirtle Squirtle!");
    }
}