using System;

public class Battle
{
    private static Random random = new Random();

    public static string StartRound(Trainer trainer1, Trainer trainer2)
    {
        Pokeball pokeball1 = trainer1.ThrowRandomPokeball();
        Pokeball pokeball2 = trainer2.ThrowRandomPokeball();

        Pokemon pokemon1 = pokeball1.Pokemon;
        Pokemon pokemon2 = pokeball2.Pokemon;

        Console.WriteLine($"{trainer1.Name} sends out {pokemon1.Nickname} ({pokemon1.Strength})");
        Console.WriteLine($"{trainer2.Name} sends out {pokemon2.Nickname} ({pokemon2.Strength})");

        int trainer1Wins, trainer2Wins, draws;
        string outcome = Fight(pokemon1, pokemon2, out trainer1Wins, out trainer2Wins, out draws);

        Arena.UpdateScoreboard(trainer1Wins, trainer2Wins, draws);

        return outcome;
    }

    private static string Fight(Pokemon pokemon1, Pokemon pokemon2, out int trainer1Wins, out int trainer2Wins, out int draws)
    {
        trainer1Wins = 0;
        trainer2Wins = 0;
        draws = 0;

        if ((pokemon1.Strength == PokemonType.Fire && pokemon2.Strength == PokemonType.Grass) ||
            (pokemon1.Strength == PokemonType.Grass && pokemon2.Strength == PokemonType.Water) ||
            (pokemon1.Strength == PokemonType.Water && pokemon2.Strength == PokemonType.Fire))
        {
            trainer1Wins = 1;
            return $"{pokemon1.Nickname} wins!";
        }
        else if ((pokemon1.Strength == PokemonType.Grass && pokemon2.Strength == PokemonType.Fire) ||
                 (pokemon1.Strength == PokemonType.Water && pokemon2.Strength == PokemonType.Grass) ||
                 (pokemon1.Strength == PokemonType.Fire && pokemon2.Strength == PokemonType.Water))
        {
            trainer2Wins = 1;
            return $"{pokemon2.Nickname} wins!";
        }
        else
        {
            draws = 1;
            return "It's a draw!";
        }
    }
}
