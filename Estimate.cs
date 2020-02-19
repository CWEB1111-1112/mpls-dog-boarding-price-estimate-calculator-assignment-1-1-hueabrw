/*

    Author: Abe Huerta
    Description: This is the estimate class that is used to create an estimate 
      price of boarding a users dog. This is part of the MPLSDogBoarding.com website.
    Repository: https://github.com/CWEB1111-1112/mpls-dog-boarding-price-estimate-calculator-assignment-1-1-hueabrw
*/
using System;


namespace assignment_one{

    class Estimate{

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

        public double estimateCost(int days, char serviceCode){
            if(serviceCode == 'N'){
                return 75.00 * days;
            }else if(serviceCode == 'A'){
                return 169.00 * days;
            }else if(serviceCode == 'C'){
                return 112.00 * days;
            }else{
                throw new System.ArgumentException("not a valid service add-on code");
            }
        }

        public override string ToString()
        {
            string cost = this.totalEstimate.ToString("c");
            string description = $"\nHello {this.owner}, \n\n{this.dogName} will be staying with us for {this.daysOfStay} days. \n{this.dogName} is {this.dogWeight} pounds and will be receiving \nthe {this.serviceAddOnCode} level service add-on. \n\nCost Estimate: {cost}\n";
            return description;
        }
    }

}