using System;

namespace RockPaperScissors
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            const string Rock = "Rock";
            const string Paper = "Paper";
            const string Scissors = "Scissors";

            bool gameLoop = true;
            int wins = 0;
            int loseses = 0;
            int draws = 0;

            while (gameLoop)
            {
                Console.Write("Choose [r]ock, [p] or [s]cissors: ");
                string playChoice = Console.ReadLine();

                switch (playChoice)
                {
                    case "r":
                    case "rock":
                        playChoice = Rock;
                        break;
                    case "p":
                    case "paper":
                        playChoice = Paper;
                        break;
                    case "s":
                    case "scissors":
                        playChoice = Scissors;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Invalid Choice! Try Again.");
                        Console.ResetColor();
                        return;
                }
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"You chose {playChoice}.");
                Console.ResetColor();

                Random random = new Random();
                int computerRandomNumber = random.Next(1, 4);
                string computerChoice = string.Empty;

                switch (computerRandomNumber)
                {
                    case 1:
                        computerChoice = Rock;
                        break;
                    case 2:
                        computerChoice = Paper;
                        break;
                    case 3:
                        computerChoice = Scissors;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"The computer chose {computerChoice}.");
                Console.ResetColor();

                if ((playChoice == Rock && computerChoice == Scissors) ||
                    (playChoice == Paper && computerChoice == Rock) ||
                    (playChoice == Scissors && computerChoice == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win.");
                    Console.ResetColor();
                    wins++;
                }
                else if ((computerChoice == Rock && playChoice == Scissors) ||
                    (computerChoice == Paper && playChoice == Rock) ||
                    (computerChoice == Scissors && playChoice == Paper))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You lose.");
                    Console.ResetColor();
                    loseses++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("The game was a draw.");
                    Console.ResetColor();
                    draws++;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Current result is W:{wins} | D:{draws} | L:{loseses}");
                Console.ResetColor();

                Console.WriteLine("Do you wanna play again?");
                Console.Write("Enter Y or N: ");
                string playAgain = Console.ReadLine();

                if (playAgain == "n" || playAgain == "N" || playAgain == "no" || playAgain == "No")
                {
                    gameLoop = false;
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"Final result is W:{wins} | D:{draws} | L:{loseses}");
                    Console.ResetColor();
                }
                else if (playAgain == "y" || playAgain == "Y" || playAgain == "yes" || playAgain == "Yes")
                {
                    Console.Clear();
                }
                else
                {
                    gameLoop = false;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Invalid choice!");
                    Console.ResetColor();
                }
            }
        }
    }
}
