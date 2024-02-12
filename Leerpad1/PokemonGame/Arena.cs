using System;

public class Arena
{
    private static int roundsFought = 0;
    private static int battlesFought = 0;
    private static int trainer1Wins = 0;
    private static int trainer2Wins = 0;
    private static int draws = 0;

    public static int Trainer1Wins { get { return trainer1Wins; } }
    public static int Trainer2Wins { get { return trainer2Wins; } }
    public static int Draws { get { return draws; } }

    public static void StartBattle(Trainer trainer1, Trainer trainer2)
    {
        Battle.StartBattle(trainer1, trainer2);
    }

    public static void DisplayScoreboard()
    {
        Console.WriteLine("\n===== Scoreboard =====");
        Console.WriteLine($"Battles fought: {battlesFought}");
        Console.WriteLine($"Rounds fought: {roundsFought}");
        Console.WriteLine($"Trainer 1 wins: {trainer1Wins}");
        Console.WriteLine($"Trainer 2 wins: {trainer2Wins}");
        Console.WriteLine($"Draws: {draws}");
        Console.WriteLine("======================");
    }

    public static void UpdateScoreboard(Trainer winner, Trainer trainer1, Trainer trainer2)
    {
        if (winner == trainer1)
            trainer1Wins++;
        else if (winner == trainer2)
            trainer2Wins++;
        else
            draws++;
    }

    public static void UpdateBattleCount()
    {
        battlesFought++;
    }

    public static void UpdateRoundCount()
    {
        roundsFought++;
    }
}