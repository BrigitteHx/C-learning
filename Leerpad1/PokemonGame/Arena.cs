// Arena.cs

using System;

class Arena
{
    private static int battlesCount = 0;
    private static int roundsCount = 0;
    private static int trainer1WinsCount = 0;
    private static int trainer2WinsCount = 0;
    private static int drawsCount = 0;

    public static void UpdateBattleCount()
    {
        battlesCount++;
    }

    public static void UpdateRoundCount()
    {
        roundsCount++;
    }

    public static void UpdateScoreboard(int trainer1Wins, int trainer2Wins, int draws)
    {
        trainer1WinsCount += trainer1Wins;
        trainer2WinsCount += trainer2Wins;
        drawsCount += draws;
    }

    public static void DisplayScoreboard()
    {
        Console.WriteLine($"\nBattle rounds: {roundsCount}");
        Console.WriteLine($"Battles fought: {battlesCount}");
        Console.WriteLine($"Wins {trainer1WinsCount} : {trainer2WinsCount} : Draws {drawsCount}");
    }

    public static void StartBattle(Trainer trainer1, Trainer trainer2)
    {
        UpdateBattleCount();

        for (int roundsFought = 1; roundsFought <= 10; roundsFought++)
        {
            UpdateRoundCount();
            Console.WriteLine($"\nRound {roundsFought} begins!");

            string outcome = Battle.StartRound(trainer1, trainer2);
            Console.WriteLine($"Round {roundsFought} outcome: {outcome}");
        }

        Console.WriteLine("\nBattle has ended.");
        DisplayScoreboard();
    }

    public static void PrepareTrainers(Trainer trainer1, Trainer trainer2)
    {
        for (int i = 0; i < 2; i++)
        {
            Bulbasaur bulb1 = new Bulbasaur($"Bulbasaur{i + 1}");
            Charmander charm1 = new Charmander($"Charmander{i + 1}");
            Squirtle squi1 = new Squirtle($"Squirtle{i + 1}");

            trainer1.AddPokeball(new Pokeball(bulb1));
            trainer1.AddPokeball(new Pokeball(charm1));
            trainer1.AddPokeball(new Pokeball(squi1));

            Bulbasaur bulb2 = new Bulbasaur($"Bulbasaur{i + 1}");
            Charmander charm2 = new Charmander($"Charmander{i + 1}");
            Squirtle squi2 = new Squirtle($"Squirtle{i + 1}");

            trainer2.AddPokeball(new Pokeball(bulb2));
            trainer2.AddPokeball(new Pokeball(charm2));
            trainer2.AddPokeball(new Pokeball(squi2));
        }
    }
}
