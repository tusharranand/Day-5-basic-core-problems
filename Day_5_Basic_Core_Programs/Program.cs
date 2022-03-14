using System;

namespace Day_5_Basic_Core_Programs
{
    class Problems
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relatvie problem.\n");
            Console.WriteLine("1 for Flip Coin and print percentage of Heads and Tails");
            Console.WriteLine("2 for Leap Year");
            Console.WriteLine("3 for Power of 2");
            Console.WriteLine("4 for Harmonic Number");
            Console.WriteLine("5 for Factors");
            Console.WriteLine("6 for Compute Quotient and Remainder");
            Console.WriteLine("7 for Swap Two Numbers");
            Console.WriteLine("8 for Check Whether a Number is Even or Odd");
            Console.WriteLine("9 for Check Whether an Alphabet is Vowel or Consonant");
            Console.WriteLine("10 for Find the Largest Among Three Numbers\n");
            int Problem = Convert.ToInt32(Console.ReadLine());

            switch (Problem)
            {
                case 1:
                    Flip_Percentage flip = new Flip_Percentage();
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }

    class Flip_Percentage
    {

        public Flip_Percentage()
        {
            int Heads = 0;
            int Tails = 0;

            Console.Write("Enter the number of times you want to flip the coin: ");
            int Number_of_Flips = Convert.ToInt32(Console.ReadLine());

            while (Number_of_Flips <= 0)
            {
                Console.WriteLine("Invalid input, please input a number greater than 0.");
                Console.Write("Please enter again: ");
                Number_of_Flips = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < Number_of_Flips; i++)
            {
                Random flip = new Random();
                int HoT = flip.Next(0, 2);

                if (HoT < 0.5)
                {
                    Heads++;
                }
                else
                {
                    Tails++;
                }
            }

            float Heads_Percent = (float)Heads * 100 / Number_of_Flips;
            float Tails_Percent = (float)Tails * 100 / Number_of_Flips;

            Console.WriteLine(Heads_Percent + "% of the times the result was heads.");
            Console.WriteLine(Tails_Percent + "% of the times the result was tails.");
        }
    }

}