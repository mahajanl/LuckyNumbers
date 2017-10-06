using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahajan_Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Why hello there! YOU have been selected for a chance to win a RIDICULOUS AMOUNT OF MONEY! \nI'll let you know how much... at some point... maybe.\n");
            //PART OF PART IV
            Console.WriteLine("Would you like a chance to win this jackpot? Even if you get only a FEW numbers right, you'll still win a portion. Type YES if you'd like to play.");
            string answer = Console.ReadLine().ToLower().Trim();

            while (answer == "yes")
            {
                Console.WriteLine("First, in order to play, you'll have to give me TWO numbers, one at a time. This will be the HIGHEST and LOWEST numbers possible. Enter the LOWEST one for me now.");
                int rangeStart = int.Parse(Console.ReadLine());
                Console.WriteLine("And now let's get your second, HIGHER (numerically...), number.");
                int rangeEnd = int.Parse(Console.ReadLine());

                Console.WriteLine("Now, let's have a little MORE fun and check on your prescient abilities. Type in the SIX (6) numbers you think will be generated within your number range, hitting ENTER after each number is typed.");
                int[] userGuess = new int[6];

                for (int i = 0; i <= 5; i++)
                {
                    Console.WriteLine("Enter a number for me");
                    userGuess[i] = int.Parse(Console.ReadLine());

                    if (userGuess[i] >= rangeStart && userGuess[i] <= rangeEnd)
                    {
                        Console.WriteLine("Excellent");
                    }

                    else if (userGuess[i] <= rangeStart || userGuess[i] >= rangeEnd)
                    {
                        Console.WriteLine("That's not a number I can use.");

                        while (userGuess[i] <= rangeStart || userGuess[i] >= rangeEnd)
                        {
                            Console.WriteLine("Enter a number for me");
                            userGuess[i] = int.Parse(Console.ReadLine());
                        }
                    }
                }


                Console.WriteLine("\n\n\n\n\nAnd now the great and powerful Luckster Number Generator will give you 6 numbers.");

                //PART II
                int[] randoGen = new int[6];
                Random randoNum = new Random();

                for (int i = 0; i <= 5; i++)
                {
                    randoGen[i] = randoNum.Next(rangeStart, rangeEnd);
                    Console.WriteLine("Lucky Number: " + randoGen[i]);
                }

                //PART III
                int jackpot = 2468975;
                int numbersRight = 0;

                foreach (int guess in userGuess)
                {
                    if (guess == randoGen[0])
                    {
                        numbersRight++;
                    }
                    else if (guess == randoGen[1])
                    {
                        numbersRight++;
                    }
                    else if (guess == randoGen[2])
                    {
                        numbersRight++;
                    }
                    else if (guess == randoGen[3])
                    {
                        numbersRight++;
                    }
                    else if (guess == randoGen[4])
                    {
                        numbersRight++;
                    }
                    else if (guess == randoGen[5])
                    {
                        numbersRight++;
                    }


                }
                int userWinnings = jackpot / numbersRight;
                Console.WriteLine("Your winnings are $" + userWinnings + "!");
                break;
            }
            
            Console.WriteLine("Thanks for playing!");












            //userGuess[0] = int.Parse(Console.ReadLine());
            //userGuess[1] = int.Parse(Console.ReadLine());
            //userGuess[2] = int.Parse(Console.ReadLine());
            //userGuess[3] = int.Parse(Console.ReadLine());
            //userGuess[4] = int.Parse(Console.ReadLine());
            //userGuess[5] = int.Parse(Console.ReadLine());




        }
    }
}
