using System;
using System.Collections.Generic;

public class Trainer
{
    private string name;
    private List<Pokeball> belt;

    public Trainer(string name)
    {
        this.name = name;
        this.belt = new List<Pokeball>();
    }

    public void AddPokeball(Pokeball pokeball)
    {
        if (belt.Count >= 6)
        {
            throw new InvalidOperationException("The belt cannot hold more than six pokeballs.");
        }
        belt.Add(pokeball);
    }

    public void ThrowPokeball(int index)
    {
        if (index < 0 || index >= belt.Count)
        {
            throw new IndexOutOfRangeException("Invalid pokeball index.");
        }
        belt[index].ThrowPokeball();
    }

    public void ReturnCharmander(int index)
    {
        if (index < 0 || index >= belt.Count)
        {
            throw new IndexOutOfRangeException("Invalid pokeball index.");
        }
        belt[index].ReturnCharmander();
    }
}
