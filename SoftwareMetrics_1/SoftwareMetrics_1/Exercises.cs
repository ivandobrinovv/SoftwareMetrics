using System;

namespace SoftwareMetrics_1
{
    class Exercises
    {
        static int SumPositive(int a, int b)
        {
            if (a <= 0) throw new ArgumentException("'a' should be positive!", "a");
            if (b <= 0) throw new ArgumentException("'b' should be positive!", "b");
            return a + b;
        }

        static bool ContainsNegative(int a, int b, int c, int d)
        {
            if (a < 0 || b < 0 || c < 0 || d < 0) return false;
            return true;
        }

        static bool ValidRGB(int r, int g, int b)
        {
            if (r < 0 || r > 255) return false;
            if (g < 0 || g > 255) return false;
            if (b < 0 || b > 255) return false;
            return true;
        }

        static void DoSomeWork(int i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Do some work, step 1");
            }
            Console.WriteLine("Other work...");

            for (int j = 1; j <= 5; j++)
            {
                Console.WriteLine($"Routine {j}");
            }

            if (i % 2 == 0)
            {
                Console.WriteLine("Do some work, step 2");
            }

            int k = 0;
            while (k < 10)
            {
                Console.WriteLine(k);
                k++;
            }

            if (i % 2 == 0)
            {
                Console.WriteLine("Do some work, step 3");
            }

            Console.WriteLine("Ready to go!");
        }

        static string Add(string number1, string number2)
        {
            int decNumber1;
            try
            {
                decNumber1 = Convert.ToInt32(number1, 8);
            }
            catch (Exception ex)
            {
                throw;
            }

            int decNumber2;
            try
            {
                decNumber2 = Convert.ToInt32(number2, 8);
            }
            catch (Exception ex)
            {
                throw;
            }

            int decResult = decNumber1 + decNumber2;
            return Convert.ToString(decResult, 8);
        }
    }
}
