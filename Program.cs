using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                int number = rnd.Next(1000, 9999);
                string num = number.ToString();
                int attempts = 0;
                int topScore = int.MaxValue;
                while (true)
                {
                    Console.Write($"Enter your guess: ");
                    string guess = Console.ReadLine();
                    if (guess.Length != 4)
                    {
                        Console.WriteLine("Please enter a valid guess");
                        continue;
                    }
                    if (!guess.All(char.IsDigit))
                    {
                        Console.WriteLine("Please enter a valid guess.");
                        continue;
                    }
 
                    if (guess[0] == '0')
                    {
                        Console.WriteLine("Please enter a valid guess.");
                        continue;
                    }
                    attempts++;
 
                    int cows = 0;
                    int bulls = 0;
                    for (int i = 0; i < num.Length; i++)
                    {
                        if (num[i] == guess[i])
                            bulls++;
                        else if (num.Contains(guess[i]))
                            cows++;
                    }
 
                    Console.WriteLine($"Cows: {cows}, Bulls: {bulls}");
 
                    if (bulls == 4)
                    {
                        Console.WriteLine($"You guessed the correct number in {attempts} attempts!");
                        if (attempts < topScore)
                            topScore = attempts;
                        break;
                    }
                }
 
                Console.WriteLine("Do you want to play again? (yes/no)");
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() != "no")
                {
                    Console.WriteLine($"Top Score: {topScore}");
                    break;
                }
            }
        }
    }
}
