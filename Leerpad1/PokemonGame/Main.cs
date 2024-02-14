// Program.cs

using System;

class Program
{
    static void Main()
    {
        bool playAgain = true;
        while (playAgain)
        {
            Console.WriteLine("Welcome to the Pokemon battle simulator!");
            Console.WriteLine("Enter a name for the first trainer:");
            string trainer1Name = Console.ReadLine();
            Trainer trainer1 = new Trainer(trainer1Name);

            Console.WriteLine("Enter a name for the second trainer:");
            string trainer2Name = Console.ReadLine();
            Trainer trainer2 = new Trainer(trainer2Name);
            Console.WriteLine();

            Arena.PrepareTrainers(trainer1, trainer2);

            Arena.StartBattle(trainer1, trainer2);

            Console.WriteLine("Do you want to play again? (yes/no)");
            string choice = Console.ReadLine();
            if (choice.ToLower() != "yes")
            {
                playAgain = false;
            }
        }
    }
}
