using System;
using System.Collections.Generic;

namespace CommissionList
{
    public class Program
    {
        static void Main()
        {
            // Keep the following line intact 
            Console.WriteLine("===========================");

            // Insert your solution here.
            Console.WriteLine("Number of sales:");
            int sales = Int32.Parse(Console.ReadLine()!);
            int[] prices = new int[sales];

            for (int i = 0; i < sales; i++)
            {
                Console.WriteLine("Sale value:");
                prices[i] = Int32.Parse(Console.ReadLine()!);
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("Your commissions:");

            decimal totalCommission = 0;

            foreach (int price in prices)
            {
                decimal commission = 0;
                if (price <= 15000)
                {
                    commission = price * 0.05M;
                }
                else if (price <= 24000) 
                {
                    commission = price * 0.07M;
                } else
                {
                    commission = price * 0.1M;
                }

                Console.WriteLine($"Commission on sale {price:C} = {commission:C}");
                totalCommission += commission;
            }

            Console.WriteLine($"Total commission = {totalCommission:C}");

            // Keep the following line intact
            Console.WriteLine("===========================");
        }
    }
}