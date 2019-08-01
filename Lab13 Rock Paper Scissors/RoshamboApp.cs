using System;

namespace Lab13_Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Player user = new UserPlayer();

            Console.WriteLine("Welcome to the Rock, Paper Scissor Arena!");
            Console.WriteLine("Enter name please");

            user.Name = Console.ReadLine();

            Console.WriteLine("Please choose an opponent Jets or Rockets");
            string teamChoice = Console.ReadLine().ToLower();
            Console.WriteLine("What would you like to throw? 1. Rock, 2. Paper, 3. Scissors, 4. Exit");
            //int.TryParse(Console.ReadLine(), out int userInput);

            string input = "4";
            bool go = true;
            while (go)
            {
                if (teamChoice == "jets")
                {
                    RandomPlayer rp = new RandomPlayer();
                    rp.Name = "Jets";
                    Roshambo userChoice = user.GenerateRoshambo();
                    Roshambo npcChoice = rp.GenerateRoshambo();
                    string result = WinLoseOrTie(userChoice, npcChoice);
                    Console.WriteLine($"{user.Name}: {userChoice} ");
                    Console.WriteLine($"{rp.Name}: {npcChoice}");
                    Console.WriteLine(result);
                }
                else if (teamChoice == "rockets")
                {
                    RockPlayer rockPlayer = new RockPlayer();
                    rockPlayer.Name = "Rockets";
                    Roshambo userChoice = user.GenerateRoshambo();
                    Roshambo npcChoice = rockPlayer.GenerateRoshambo();
                    string result = WinLoseOrTie(userChoice, npcChoice);
                    Console.WriteLine($"{user.Name}: {userChoice}");
                    Console.WriteLine($"{rockPlayer.Name}: {npcChoice}");
                    Console.WriteLine(result);
                }
                
                else
                {
                    Console.WriteLine("Not vaild please try again");
                }
            }

            //RandomPlayer rp = new RandomPlayer();
            //Console.WriteLine(rp.GenerateRoshambo());
        }
        public static string WinLoseOrTie(Roshambo userChoice, Roshambo npcChoice)
        {
            if (userChoice.Equals(npcChoice))
            {
                return "Tie...";
            }
            else if(userChoice == Roshambo.Rock && npcChoice == Roshambo.Scissors || userChoice == Roshambo.Scissors && npcChoice == Roshambo.Paper || userChoice == Roshambo.Paper && npcChoice == Roshambo.Rock)
            {
                return "Winner!";
            }
            else
            {
                return "Loser!";
            }

        }
        public static bool Continue(int counter)
        {
            Console.WriteLine($"Press {'y'} to continue or any other key to exit. . .\n");

            char response = Console.ReadKey(true).KeyChar;

            if (response == 'y')
            {
                Console.Clear();
                return true;
            }
            else if (response != 'y')
            {
                Console.WriteLine($"GoodBye! You played {counter} games");
                return false;
            }
            else
            {
                return Continue(counter);
            }
        }
    }
}
