using System;

public class Pokeball
{
    private bool isOpen;
    private Pokemon pokemon = null!;

    public bool IsOpen
    {
        get { return isOpen; }
        private set { isOpen = value; }
    }

    public Pokemon Pokemon
    {
        get { return pokemon; }
        private set { pokemon = value; }
    }

    public Pokeball(Pokemon pokemon)
    {
        this.Pokemon = pokemon;
        this.IsOpen = false;
        Console.WriteLine("The pokeball releases the Pokémon!");
        pokemon.BattleCryShout(); 
        IsOpen = true;
    }

    public void ReturnPokemon()
    {
        Console.WriteLine("The Pokémon returns to the pokeball.");
        IsOpen = false;
    }
}
