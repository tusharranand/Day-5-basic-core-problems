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
                case 2:
                    Leap_Year year = new Leap_Year();
                    break;
                case 3:
                    Power_of_Two iterations = new Power_of_Two();
                    break;
                case 4:
                    Harmonics Nth = new Harmonics();
                    break;
                case 5:
                    Factors prime = new Factors();
                    break;
                case 6:
                    Divide calculate = new Divide();
                    break;
                case 7:
                    Swap numbers = new Swap();
                    break;
                case 8:
                    Even_or_Odd check = new Even_or_Odd();
                    break;
                case 9:
                    Vowel_or_Consonant compare = new Vowel_or_Consonant();
                    break;
                case 10:
                    Comparing largest = new Comparing();  
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

    class Leap_Year
    {
        public Leap_Year()
        {
            Console.Write("Enter the year: ");
            int Year = Convert.ToInt32(Console.ReadLine());

            while (Year < 1000 || Year > 9999)
            {
                Console.Write("Please enter a four digit year: ");
                Year = Convert.ToInt32(Console.ReadLine());
            }

            if (((Year % 4 == 0) && (Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine(Year + " is a leap year");
            }
            else
            {
                Console.WriteLine(Year + " is not a leap year");
            }

        }
    }

    class Power_of_Two
    {
        public Power_of_Two()
        {
            Console.Write("Please enter a number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            while (Number < 0 || Number >= 31)
            {
                Console.Write("Please enter a valid number: ");
                Number = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }

    class Harmonics
    {
        public Harmonics()
        {
            float Result_Harmonic = 0;

            Console.Write("Enter the value of N for Nth Harmonic: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (float i = 1; i <= N; i++)
            {
                Result_Harmonic += 1 / i;
            }
            Console.WriteLine("The Nth Harmonic is given by {0}", Result_Harmonic);
        }
    }

    class Factors
    {
        public Factors()
        {
            Console.Write("Enter the Numbe: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Prime Factors for {0] are,", Number);

            for (int i = 2; i * i <= Number; i++)
            {
                if (Number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }

    class Divide
    {
        public Divide()
        {
            Console.Write("Enter the Dividend: ");
            int Dividend = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Divisor: ");
            int Divisor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quotient = " + Dividend / Divisor);
            Console.WriteLine("Remainder = " + Dividend % Divisor);

        }
    }

    class Swap
    {
        public Swap()
        {
            Console.Write("Enter a two digit Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            int Reverse = 0;

            for (int i = 1; i >= 0; i--)
            {
                Reverse += (Number % 10) * (int)Math.Pow(10, i);
                Number = Number / 10;
            }
            Console.WriteLine("The reverse of given number is: " + Reverse);
        }
    }

    class Even_or_Odd
    {
        public Even_or_Odd()
        {
            Console.Write("Enter a Number: ");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number % 2 == 0)
            {
                Console.WriteLine(Number + " is an Even Number.");
            }
            else
            {
                Console.WriteLine(Number + " is an Odd Number.");
            }
        }
    }

    class Vowel_or_Consonant
    {
        public Vowel_or_Consonant()
        {
            char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

            Console.Write("Enter the alphabet: ");
            char Alph = char.ToLower(Convert.ToChar(Console.ReadLine()));

            for (int i = 0; i <= Vowels.Length; i++)
            {
                if (i == 5)
                {

                    Console.WriteLine(Alph + " is a Consonant.");
                }
                else if (Alph == Vowels[i])
                {
                    Console.WriteLine(Alph + " is a Vowel.");
                    break;
                }
            }
        }
    }

    class Comparing
    {
        public Comparing()
        {
            int[] Numbers = new int[3];

            Console.Write("Enter the first Number: ");
            Numbers[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Number: ");
            Numbers[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third Number: ");
            Numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Numbers.Max() + " is the largest of the given numbers.");
        }
    }
}