/*

    Author: Abe Huerta
    Description: This is the estimate class that is used to create an estimate 
      price of boarding a users dog. This is part of the MPLSDogBoarding.com website.
    Repository: https://github.com/CWEB1111-1112/mpls-dog-boarding-price-estimate-calculator-assignment-1-1-hueabrw
*/
using System;


namespace assignment_one{

    class Estimate{

        string owner;
        string dogName;
        string dogWeight;
        int daysOfStay;
        char serviceAddOnCode;
        double totalEstimate;

        public Estimate(string owner, string dogName, string dogWeight, int daysOfStay, char serviceAddOnCode, double totalEstimate)
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
                return 75.00;
            }else if(serviceCode == 'A'){
                return 169.00;
            }else if(serviceCode == 'C'){
                return 112.00;
            }else{
                throw new System.ArgumentException("not a valid service add-on code");
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }

}