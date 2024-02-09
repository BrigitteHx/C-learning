using System;

class Program
{
    static void Main()
    {
        bool game = true;

        while (game)
        {
            Console.WriteLine("Welcome to the Pokemon game!");
            Console.WriteLine("Enter a name for the first trainer:");
            string trainer1Name = Console.ReadLine();
            Trainer trainer1 = new Trainer(trainer1Name);

            Console.WriteLine("Enter a name for the second trainer:");
            string trainer2Name = Console.ReadLine();
            Trainer trainer2 = new Trainer(trainer2Name);
            Console.WriteLine("\n");

            // apart 2 voor Bulbasaurs, 2 Charmanders, 2 Squirtles voor elk trainer
            for (int i = 0; i < 2; i++)
            {
                Bulbasaur bulb = new Bulbasaur($"Bulbasaur{i + 1}");
                Charmander charm = new Charmander($"Charmander{i + 1}");
                Squirtle squi = new Squirtle($"Squirtle{i + 1}");

                Pokeball pokeball1 = new Pokeball(bulb);
                Pokeball pokeball2 = new Pokeball(charm);
                Pokeball pokeball3 = new Pokeball(squi);

                trainer1.AddPokeball(pokeball1);
                trainer1.AddPokeball(pokeball2);
                trainer1.AddPokeball(pokeball3);

                trainer2.AddPokeball(pokeball1);
                trainer2.AddPokeball(pokeball2);
                trainer2.AddPokeball(pokeball3);
            }

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine($"Trainer {trainer1Name} throws his {i + 1} pokeball from his belt.");
                trainer1.ThrowPokeball(i);
                Console.WriteLine("\n");

                Console.WriteLine($"Trainer {trainer2Name} throws his {i + 1} pokeball from his belt.");
                trainer2.ThrowPokeball(i);
                Console.WriteLine("\n");

                Console.WriteLine($"Trainer {trainer1Name}");
                trainer1.ReturnCharmander(i);
                Console.WriteLine("\n");

                Console.WriteLine($"Trainer {trainer2Name}");
                trainer2.ReturnCharmander(i);
                Console.WriteLine("\n");
            }

            Console.WriteLine("Do you want to play again? (yes/no)");
            Console.WriteLine("\n");
            string choice = Console.ReadLine();
            if (choice.ToLower() != "yes")
            {
                game = false;
            }
        }
    }
}
