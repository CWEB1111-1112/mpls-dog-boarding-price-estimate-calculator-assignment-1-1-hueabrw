﻿using System;

namespace assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            while(running){
                
                Welcome();

                Console.Write("Your Name: ");
                String owner = Console.ReadLine();

                Console.Write("Dogs name: ");
                String dogName = Console.ReadLine();
                
                double dogWeight = getWeight();

                int daysOfStay =  getDays();

                char serviceCode = getServiceCode();

                Estimate estimate = new Estimate(owner, dogName, dogWeight, daysOfStay, serviceCode);

                Console.Clear();
                Console.WriteLine(estimate.ToString());

                running =  NewEstimate();


            }
        }
        //Welcome module
        public static void Welcome(){
            Console.Clear();
            Console.WriteLine("Welcome to the MPLS Dog Boarding estimate calculator!");
            Console.WriteLine("\nPlease complete the following form:");
        }

        //Ending Module - A recursive method to see if the user needs to make
        // another estimate or wants to end the program
        public static bool NewEstimate(){
            Console.WriteLine("Would you like to make another estimate? (Y/N)");
            string input = Console.ReadLine();
            if(input.ToUpper() == "Yes" || input.ToUpper() == "Y"){
                return true;
            }else if(input.ToUpper() == "No" || input.ToUpper() == "N"){
                return false;
            }else{
                return NewEstimate();
            }
        }
        //A recursive method for making sure the user inputs a number for the dogs weight
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
        //A recursive method for making sure the user inputs a number for the number of days stayed
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
        // A recursive method for making sure the user inputs either 'N', 'A', or 'C' for the
        //   service add-on code. 
        public static char getServiceCode(){
            
            Console.Write("Service add on: ");
            var input = Console.ReadLine();
            try{
                char code = Convert.ToChar(input.ToUpper());
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
