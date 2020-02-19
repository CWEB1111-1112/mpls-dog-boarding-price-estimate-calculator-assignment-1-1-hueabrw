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
            
            double dogWeight = getWeight();

            int daysOfStay =  getDays();

            char serviceCode = getServiceCode();

            Estimate estimate = new Estimate(owner, dogName, dogWeight, daysOfStay, serviceCode);

            Console.WriteLine(estimate.ToString());

        }
        public static double getWeight(){
            
            Console.Write("Dogs wieght: ");
            var input = Console.ReadLine();
            try{
                double weight = Convert.ToDouble(input);
                return weight;
            }catch{
                Console.WriteLine("Please enter a valid weight.");
                return getWeight();
            }
        }
        public static int getDays(){
            
            Console.Write("Number of days dog will stay: ");
            var input = Console.ReadLine();
            try{
                int days = Convert.ToInt32(input);
                return days;
            }catch{
                Console.WriteLine("Please enter a valid number of days.");
                return getDays();
            }
        }
        public static char getServiceCode(){
            
            Console.Write("Service add on: ");
            var input = Console.ReadLine();
            try{
                char code = Convert.ToChar(input);
                if(code != 'N' && code != 'A' && code != 'C'){
                    throw new System.Exception();
                }else{
                    return code;
                }
            }catch{
                Console.WriteLine("Please enter a valid service code (either N, A, or C).");
                return getServiceCode();
            }
        }
    }
}
