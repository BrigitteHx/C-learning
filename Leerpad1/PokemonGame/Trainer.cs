using System;
using System.Collections.Generic;

public class Trainer
{
    private string name;
    private List<Pokeball> belt;

    public string Name { get { return name; } }

    public List<Pokeball> Belt { get { return belt; } }

    public Trainer(string name)
    {
        this.name = name;
        this.belt = new List<Pokeball>();
    }

    public void AddPokeball(Pokeball pokeball)
    {
        if (belt.Count >= 6)
        {
            Console.WriteLine("The belt cannot hold more than six pokeballs.");
        }
        else
        {
            belt.Add(pokeball);
        }
    }

    public Pokeball ThrowRandomPokeball()
    {
        Random random = new Random();
        int index = random.Next(belt.Count);
        return belt[index];
    }
}
