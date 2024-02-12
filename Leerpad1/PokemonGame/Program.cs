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

            for (int i = 0; i < 2; i++)
            {
                Bulbasaur bulb = new Bulbasaur($"Bulbasaur{i + 1}");
                Charmander charm = new Charmander($"Charmander{i + 1}");
                Squirtle squi = new Squirtle($"Squirtle{i + 1}");

                trainer1.AddPokeball(new Pokeball(bulb));
                trainer1.AddPokeball(new Pokeball(charm));
                trainer1.AddPokeball(new Pokeball(squi));

                trainer2.AddPokeball(new Pokeball(bulb));
                trainer2.AddPokeball(new Pokeball(charm));
                trainer2.AddPokeball(new Pokeball(squi));
            }

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
