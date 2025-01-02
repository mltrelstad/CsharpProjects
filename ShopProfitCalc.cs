/*This program will help find the cost per computer to earn a 20% profit from each sold.
 * Things to note:
 * a) Merchandise entered is how much it costs in materials per computer
 * b) Store Rent is on a yearly basis
 * c) Employee salary is per year
 * d) electrical Cost is per month
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace eventVenue
{
    class MerchShop
    {
        static void Main(string[] args)
        {
//Variables
            double merch;  //per PC
            double rent;   //per year
            double salary; //per year
            double nrg;    //per month
            double electricYearly;
            double yearlyCost;
            double maxPCS = 5200;
            double maxPCcost;
            double costPerPC;
            double profitPC;
            double profit = 0.20;


//Inputs
            Console.WriteLine("To find out how much each PC should cost: \r\n");
            Console.WriteLine("Please enter how much it costs to produce one PC: ");
            merch  = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how much rent costs yearly: ");
            rent = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the total yearly salary of employees: ");
            salary = Double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter how much electricity costs monthly: ");
            nrg = Double.Parse(Console.ReadLine());

//Outputs
            Console.WriteLine("\r\n");
            Console.WriteLine("To confirm, you entered: ");
            Console.WriteLine("One PC costs $" + merch );
            Console.WriteLine("Yearly rent costs $" + rent );
            Console.WriteLine("Annual salary costs $" + salary );
            Console.WriteLine("Monthly electricty bill costs $" + nrg );
            Console.WriteLine("Press 'Enter' to continue");
            Console.Read();


//Math
            Convert.ToInt32(merch);
            Convert.ToInt32(rent);
            Convert.ToInt32(salary);
            Convert.ToInt32(nrg);
            maxPCcost = (int)(merch * maxPCS);
            Console.WriteLine("Total yearly cost for PCs: $" + maxPCcost);
            electricYearly = (int)(nrg * 12);
            Console.WriteLine("Total cost yearly for electricity: $" + electricYearly);
            yearlyCost = (int)(maxPCcost + electricYearly + salary + rent);
            Console.WriteLine("Total costs yearly: $" + yearlyCost);
            Console.WriteLine("Press 'Enter' to continue");
            Console.Read();

            //Final Outputs

            costPerPC = (int)(yearlyCost / maxPCS);
            Console.WriteLine("Total cost per PC: $" + costPerPC);
            profitPC = (int)(costPerPC + (costPerPC * profit));
            Console.WriteLine("To gain a 20% Profit, each PC should be sold at:");
            Console.WriteLine("~~~~   $" + profitPC + " each.   ~~~~\r\n");
            Console.WriteLine("Press 'Enter' to continue");
            Console.Read();
        }
    }
}