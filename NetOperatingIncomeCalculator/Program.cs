using System;

namespace NetOperatingIncomeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your Operating Revenue?: ");

            int operatingRevenue = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your Operating Expense?: ");

            int operatingExpense = Convert.ToInt32(Console.ReadLine());

            int NetOperatingIncome = operatingRevenue - operatingExpense;

            Console.Write("Your Net Operating Income is " + NetOperatingIncome);
        }
    }
}
