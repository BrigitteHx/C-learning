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

            for (int i = 0; i < 6; i++)
            {
                Charmander charmander = new Charmander($"Charmander{i + 1}", "Fire", "Water");
                Pokeball pokeball1 = new Pokeball(charmander);
                Pokeball pokeball2 = new Pokeball(charmander);
                trainer1.AddPokeball(pokeball1);
                trainer2.AddPokeball(pokeball2);
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
