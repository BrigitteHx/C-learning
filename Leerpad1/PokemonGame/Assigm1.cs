using System;
using System.Collections.Generic;

public class Charmander
{
    private string nickname;
    private string strength;
    private string weakness;

    public Charmander(string nickname, string strength, string weakness)
    {
        this.nickname = nickname;
        this.strength = strength;
        this.weakness = weakness;
    }

    public void BattleCryShout()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{nickname} powerrr!");
        }
    }
}

public class Pokeball
{
    private bool isEmpty = true;
    private Charmander containedCharmander;

    public void Open()
    {
        Console.WriteLine("pokeball is open");
    }

    public void Close()
    {
        Console.WriteLine("pokeball is dicht");
    }

    public void Capture(Charmander charmander)
    {
        if (isEmpty)
        {
            Console.WriteLine("charmander is gevangen, yay!");
            containedCharmander = charmander;
            isEmpty = false;
        }
        else
        {
            Console.WriteLine("pokeball is al vol");
        }
    }

    public void Release()
    {
        if (!isEmpty)
        {
            Console.WriteLine("charmander is vrij!!");
            containedCharmander = null;
            isEmpty = true;
        }
        else
        {
            Console.WriteLine("pokeball is leeg");
        }
    }

    public bool IsEmpty()
    {
        return isEmpty;
    }

    public Charmander GetCharmander()
    {
        return containedCharmander;
    }
}

public class Trainer
{
    private string name;
    private List<Pokeball> belt = new List<Pokeball>();

    public Trainer(string name)
    {
        this.name = name;
    }

    public void ThrowPokeball()
    {
        if (belt.Count >= 6)
        {
            throw new InvalidOperationException("de trainers riem is al vol");
        }

        Pokeball pokeball = new Pokeball();
        pokeball.Capture(new Charmander("charmander", "fire", "water"));
        belt.Add(pokeball);
    }

    public void ReturnPokemon()
    {
        if (belt.Count == 0)
        {
            Console.WriteLine("de trainers riem is leeg");
            return;
        }

        Pokeball pokeball = belt[belt.Count - 1];
        pokeball.Release();
        belt.RemoveAt(belt.Count - 1);
    }

    public Charmander GetCharmander()
    {
        foreach (Pokeball pokeball in belt)
        {
            if (!pokeball.IsEmpty())
            {
                return pokeball.GetCharmander();
            }
        }
        return null;
    }

    public Pokeball GetPokeball()
    {
        foreach (Pokeball pokeball in belt)
        {
            if (!pokeball.IsEmpty())
            {
                return pokeball;
            }
        }
        return null;
    }

    public bool HasPokeballs()
    {
        foreach (Pokeball pokeball in belt)
        {
            if (!pokeball.IsEmpty())
            {
                return true;
            }
        }
        return false;
    }
}

class MainProgram
{
    static void Main()
    {
        bool quit = false;

        while (!quit)
        {
            Console.WriteLine("welkom bij de pokemon battle");
            Console.WriteLine("1. start de battle");
            Console.WriteLine("2. stop programma");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    StartBattle();
                    break;
                case "2":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("niet goed, probeer opnieuw");
                    break;
            }
        }
    }

    static void StartBattle()
    {
        Console.WriteLine("naam van trainer 1:");
        string trainer1Name = Console.ReadLine();
        Console.WriteLine("naam van trainer 2:");
        string trainer2Name = Console.ReadLine();

        Trainer trainer1 = new Trainer(trainer1Name);
        Trainer trainer2 = new Trainer(trainer2Name);

        try
        {
            trainer1.ThrowPokeball();
            trainer2.ThrowPokeball();

            // battle 
            while (trainer1.HasPokeballs() || trainer2.HasPokeballs())
            {
                Console.WriteLine($"trainer 1 ({trainer1Name})'s pokemon:");
                if (trainer1.HasPokeballs())
                {
                    Pokeball pokeball1 = trainer1.GetPokeball();
                    pokeball1.Open();
                    Charmander charmander1 = trainer1.GetCharmander();
                    charmander1.BattleCryShout();
                    pokeball1.Close();
                    trainer1.ReturnPokemon();
                }

                Console.WriteLine($"trainer 2 ({trainer2Name})'s pokemon:");
                if (trainer2.HasPokeballs())
                {
                    Pokeball pokeball2 = trainer2.GetPokeball();
                    pokeball2.Open();
                    Charmander charmander2 = trainer2.GetCharmander();
                    charmander2.BattleCryShout();
                    pokeball2.Close();
                    trainer2.ReturnPokemon();
                }
            }
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
