
using System;

public class Battle
{
    private static Random random = new Random();
    private const int MaxRounds = 10;

    public static void StartBattle(Trainer trainer1, Trainer trainer2)
    {
        Arena.UpdateBattleCount();

        for (int roundsFought = 1; roundsFought <= MaxRounds; roundsFought++)
        {
            Arena.UpdateRoundCount();
            Console.WriteLine($"\nRound {roundsFought} begins!");

            string outcome = StartRound(trainer1, trainer2);
            Console.WriteLine($"Round {roundsFought} outcome: {outcome}");

            if (outcome.Contains("wins"))
            {
                Trainer winner = outcome.Split(' ')[0] == trainer1.Name ? trainer1 : trainer2;
                Arena.UpdateScoreboard(winner, trainer1, trainer2);
                if (trainer1.Belt.Count == 0 || trainer2.Belt.Count == 0)
                    break;
            }
            else
            {
                Arena.UpdateScoreboard(null, trainer1, trainer2);
            }
        }

        Console.WriteLine("\nBattle has ended.");
        Arena.DisplayScoreboard();
    }

    public static string StartRound(Trainer trainer1, Trainer trainer2)
    {
        Pokeball pokeball1 = trainer1.ThrowRandomPokeball();
        Pokeball pokeball2 = trainer2.ThrowRandomPokeball();

        Pokemon pokemon1 = pokeball1.Pokemon;
        Pokemon pokemon2 = pokeball2.Pokemon;

        Console.WriteLine($"{trainer1.Name} sends out {pokemon1.Nickname} ({pokemon1.Strength})");
        Console.WriteLine($"{trainer2.Name} sends out {pokemon2.Nickname} ({pokemon2.Strength})");

        return Fight(pokemon1, pokemon2);
    }


    private static string Fight(Pokemon pokemon1, Pokemon pokemon2)
    {
        if (IsStrongAgainst(pokemon1.Type, pokemon2.Type))
            return $"{pokemon1.Nickname} wins!";
        else if (IsStrongAgainst(pokemon2.Type, pokemon1.Type))
            return $"{pokemon2.Nickname} wins!";
        else
            return "It's a draw!";
    }

    private static bool IsStrongAgainst(PokemonType attackingType, PokemonType defendingType)
    {
        switch (attackingType)
        {
            case PokemonType.Fire:
                return defendingType == PokemonType.Grass;
            case PokemonType.Water:
                return defendingType == PokemonType.Fire;
            case PokemonType.Grass:
                return defendingType == PokemonType.Water;
            default:
                return false; // rest zal neutraal moeten zijn 
        }
    }


}