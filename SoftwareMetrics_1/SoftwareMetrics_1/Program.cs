using System;
using System.Text;

namespace SoftwareMetrics_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ReadKey();
        }

        //CC: 1
        //NPath: 
        public static bool IsNumber(string n)
        {
            int i;
            return int.TryParse(n, out i);
        }

        //CC: 2
        //NPath: 
        public static bool IsNumber2(string n)
        {
            int i;
            bool parsed = int.TryParse(n, out i);
            if (parsed)
            {
                return true;
            }
            return false;
        }

        //CC: 2
        //NPath: 
        public static bool IsNumber3(string n)
        {
            try
            {
                int.Parse(n);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //CC: 3
        //NPath: 
        public static void Work(string i)
        {
            int n = 0;
            if (int.TryParse(i, out n))
            {
                for (int j = 0; j < n; j++)
                {
                    //Do work
                }
            }
        }

        //CC: 3
        //NPath: 
        public static void CompareNumbers(int x, int y)
        {
            if (x == y) Console.Write("Equal");
            else if (x > y) Console.Write("x is bigger than y.");
            else Console.Write("y is bigger than x.");
        }

        //CC: 5
        //NPath: 
        public static void CompareNumbers2(string x, string y)
        {
            int i, j;
            if (int.TryParse(x, out i) && int.TryParse(y, out j))
            {
                if (i == j) Console.Write("Equal");
                else if (i > j) Console.Write("x is bigger than y.");
                else Console.Write("y is bigger than x.");
            }
            else
            {
                Console.WriteLine("Inputs aren't numbers");
            }
        }

        //CC: 12
        //NPath: 
        public static void TriangleType(int a, int b, int c)
        {
            string type = "разностранен";
            if (a == b || b == c || c == a)
            {
                type = "равнобедрен";
            }
            if (a == b && a == c)
            {
                type = "равностранен";
            }
            if (a > b + c || b > a + c || c > a + b)
            {
                type = "Не съществува";
            }
            if (a <= 0 || b <= 0 || c <= 0)
            {
                type = "Невалидни данни";
            }
            Console.WriteLine($"Триъгълник със страни {a}, {b}, {c} е {type}.");
        }
        
        //CC: 4
        //NPath: 
        public static void GetMedal(int position)
        {
            string medal = null;
            switch (position)
            {
                case 1:
                    medal = "Gold";
                break;
                case 2:
                    medal = "Silver";
                    break;
                case 3:
                    medal = "Bronze";
                    break;
                default:
                    medal = "Sorry, try again next time!";
                break;
            }
            Console.WriteLine(medal);
        }

        //CC: 4
        //NPath: 
        public static void GetMedal2(int position)
        {
            string medal = null;
            if (position == 1)
            {
                medal = "Gold";
            }
            else if (position == 2)
            {
                medal = "Silver";
            }
            else if (position == 3)
            {
                medal = "Bronze";
            }
            else
            {
                medal = "Sorry, try again next time!";
            }
            Console.WriteLine(medal);
        }
    }
}
