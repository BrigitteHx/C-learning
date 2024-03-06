using System;

public class Charmander : Pokemon
{
    public Charmander(string nickname) : base(nickname, PokemonType.Fire, PokemonType.Water)
    {
        Console.WriteLine($"{Nickname}: Charmander powerrr!");
    }
}