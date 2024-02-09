using System;

public class Pokeball
{
    private bool isOpen;
    private Pokemon pokemon;

    public Pokeball(Pokemon pokemon)
    {
        this.pokemon = pokemon;
        this.isOpen = false;
    }

    public void ThrowPokeball()
    {
        Console.WriteLine("The pokeball releases the Pokémon!");
        pokemon.BattleCryShout();
        isOpen = true;
    }

    public void ReturnPokemon()
    {
        Console.WriteLine("The Pokémon returns to the pokeball.");
        isOpen = false;
    }

    public bool IsOpen()
    {
        return isOpen;
    }
}
