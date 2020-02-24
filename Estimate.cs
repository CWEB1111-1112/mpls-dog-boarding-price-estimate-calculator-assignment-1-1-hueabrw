/*

    Author: Abe Huerta
    Description: This is the estimate class that is used to create an estimate 
      price of boarding a users dog. This is part of the MPLSDogBoarding.com website.
    Repository: https://github.com/CWEB1111-1112/mpls-dog-boarding-price-estimate-calculator-assignment-1-1-hueabrw

*/
using System;


namespace assignment_one{

    class Estimate{

        private const double NTYPE = 75.00;
        private const double ATYPE = 169.00;
        private const double CTYPE = 112.00;

        protected string owner {get; set;}
        protected string dogName {get; set;}
        protected double dogWeight {get; set;}
        protected int daysOfStay {get; set;}
        protected char serviceAddOnCode {get; set;}
        protected double totalEstimate {get; set;}

        public Estimate(string owner, string dogName, double dogWeight, int daysOfStay, char serviceAddOnCode)
        {
            this.owner = owner;
            this.dogName = dogName;
            this.dogWeight = dogWeight;
            this.daysOfStay = daysOfStay;
            this.serviceAddOnCode = serviceAddOnCode;
            this.totalEstimate = estimateCost(this.daysOfStay, this.serviceAddOnCode);
        }
        //The calculator for the estimate as well as some error handling.
        public double estimateCost(int days, char serviceCode){
            if(serviceCode == 'N'){
                return NTYPE * days;
            }else if(serviceCode == 'A'){
                return ATYPE * days;
            }else if(serviceCode == 'C'){
                return CTYPE * days;
            }else{
                throw new System.ArgumentException("not a valid service add-on code");
            }
        }
        // A ToString method describing the estimate information and showing the total estimate cost.
        public override string ToString()
        {
            string cost = this.totalEstimate.ToString("c");
            string description = $"\nHello {this.owner}, \n\nThank you for your interest in MPLS dog boarding. \nJust to confirm, {this.dogName} will be staying with us \nfor {this.daysOfStay} days. {this.dogName} is {this.dogWeight} pounds and will be \nreceiving the {this.serviceAddOnCode} level service add-on. \n\nCost Estimate: {cost}\n";
            return description;
        }
    }

}