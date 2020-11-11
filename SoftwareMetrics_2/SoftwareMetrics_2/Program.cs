namespace SoftwareMetrics_2
{
    using SoftwareMetrics_2_Shapes;
    using SoftwareMetrics_2_Workflow;
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main(string[] args)
        {
            Shape myCustomShape = new Shape()
            {
                Lines = new List<Line>()
                {
                    new Line(0, 0, 1, 2),
                    new Line(new Point(1, 1), new Point(3, 6)),
                    new Line(5, 12, 17, 22)
                }
            };
            Console.WriteLine(myCustomShape.Draw());

            List<IShape> myShapes = new List<IShape>()
            {
                new Line(0,0, 5, 5),
                new Point(8, 12),
                new Line(new Point(123, 123), new Point(555, 444))
            };
            string errorBuffer = string.Empty;
            string blackboard = string.Empty;
            foreach (IShape shape in myShapes)
            {
                if (shape.IsValid())
                {
                    blackboard += shape.Draw();
                    blackboard += Environment.NewLine;
                }
                else
                {
                    errorBuffer += $"Shape: {shape.Draw()} is not valid";
                    errorBuffer += Environment.NewLine;
                }
            }
            Console.WriteLine("Blackboard:");
            Console.WriteLine(blackboard);
            Console.WriteLine("Existing errors:");
            Console.WriteLine(errorBuffer);
            Console.ReadKey();
            return;

            //Employee employee = new Employee();
            //employee.JobTitle = "ala-bala";
            //Console.WriteLine(employee.IsJobValid());
        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello World!!!");
        }

        public void HelloWithDate()
        {
            Console.WriteLine("Hello World!!! Now: {0}", DateTime.Now);
        }

        public void HelloFromPerson(Person person)
        {
            Console.WriteLine("Hello World!!! My name is: {0}. I'm {1} years old. DoB: {2}",
                person.Name, person.Age, person.DoB);
        }

        public static decimal Calculate(decimal amount, int type, int years)
        {
            decimal result = 0;
            decimal disc = (years > 5) ? (decimal)5 / 100 : (decimal)years / 100;
            if (type == 1)
            {
                result = amount;
            }
            else if (type == 2)
            {
                result = (amount - (0.1m * amount)) - disc * (amount - (0.1m * amount));
            }
            else if (type == 3)
            {
                result = (0.7m * amount) - disc * (0.7m * amount);
            }
            else if (type == 4)
            {
                result = (amount - (0.5m * amount)) - disc * (amount - (0.5m * amount));
            }
            return result;
        }

        public static decimal ApplyDiscount(decimal price, AccountStatus accountStatus, int timeOfHavingAccountInYears)
        {
            decimal priceAfterDiscount = 0;
            switch (accountStatus)
            {
                case AccountStatus.NotRegistered:
                    priceAfterDiscount = price;
                    break;
                case AccountStatus.SimpleCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants2.DISCOUNT_FOR_SIMPLE_CUSTOMERS);
                    break;
                case AccountStatus.ValuableCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants2.DISCOUNT_FOR_VALUABLE_CUSTOMERS);
                    break;
                case AccountStatus.MostValuableCustomer:
                    priceAfterDiscount = price.ApplyDiscountForAccountStatus(Constants2.DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS);
                    break;
                default:
                    throw new NotImplementedException();
            }
            priceAfterDiscount = priceAfterDiscount.ApplyDiscountForTimeOfHavingAccount(timeOfHavingAccountInYears);
            return priceAfterDiscount;
        }
    }
    public enum AccountStatus
    {
        NotRegistered = 1,
        SimpleCustomer = 2,
        ValuableCustomer = 3,
        MostValuableCustomer = 4
    }

    public static class Constants2
    {
        public const int MAXIMUM_DISCOUNT_FOR_LOYALTY = 5;
        public const decimal DISCOUNT_FOR_SIMPLE_CUSTOMERS = 0.1m;
        public const decimal DISCOUNT_FOR_VALUABLE_CUSTOMERS = 0.3m;
        public const decimal DISCOUNT_FOR_MOST_VALUABLE_CUSTOMERS = 0.5m;
    }

    public static class PriceExtensions
    {
        public static decimal ApplyDiscountForAccountStatus(this decimal price, decimal discountSize)
        {
            return price - (discountSize * price);
        }

        public static decimal ApplyDiscountForTimeOfHavingAccount(this decimal price, int timeOfHavingAccountInYears)
        {
            decimal discountForLoyaltyInPercentage = (timeOfHavingAccountInYears > Constants2.MAXIMUM_DISCOUNT_FOR_LOYALTY) ? (decimal)Constants2.MAXIMUM_DISCOUNT_FOR_LOYALTY / 100 : (decimal)timeOfHavingAccountInYears / 100;
            return price - (discountForLoyaltyInPercentage * price);
        }
    }
}
