using System;

namespace assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the MPLS Dog Boarding estimate calculator!");
            Console.WriteLine("\nPlease complete the following form:");
            Console.Write("Your Name: ");
            String owner = Console.ReadLine();
            Console.Write("Dogs name: ");
            String dogName = Console.ReadLine();
            Console.Write("Dogs wieght: ");
            double dogWeight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Number of days dog will stay: ");
            int daysOfStay =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Service add on: ");
            char serviceCode = Convert.ToChar(Console.ReadLine().ToUpper());

            Estimate estimate = new Estimate(owner, dogName, dogWeight, daysOfStay, serviceCode);

            Console.WriteLine(estimate.ToString());
        }
    }
}
