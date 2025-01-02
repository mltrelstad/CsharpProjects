using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace eventVenue
{
    class Program
    {
        static void Main(string[] args)
        {
        //Variables
            int Orchestra = 100;
            int floor = 75;
            int tier1 = 50;
            int tier2 = 40;
            int tier3 = 35;
            int amount = 0;
            string a = "Orchestra";
            string b = "Floor";
            string c = "Tier 1";
            string d = "Tier 2";
            string e = "Tier 3";
            

        // Output of text to the user
            Console.WriteLine("What level ticket did you purchase?");
            Console.WriteLine("(a) Orchestra");
            Console.WriteLine("(b) Floor");
            Console.WriteLine("(c) Tier 1");
            Console.WriteLine("(d) Tier 2");
            Console.WriteLine("(e) Tier 3");

        // Reading line of text
            string input1 = Console.ReadLine();

        //If statement
            if(input1 == "a")
            {
                Console.WriteLine("Your ticket level: " + a);
                Console.Write("How many tickets did you purchase?: ");
                string input2 = Console.ReadLine();
                int number = Convert.ToInt32(input2);
                int total;
                total = number * Orchestra;
                Console.Write("\r\n");
                Console.Write("Your ticket: " + a + "\r\n");
                Console.Write("Ticket cost: $" + Orchestra + "\r\n");
                Console.Write("Amount of tickets: " + input2 + "\r\n");
                Console.Write("Your total cost: $" + total + "\r\n");
                Console.Write("Press 'Enter' to exit");
                Console.Read();
            }
            if (input1 == "b")
            {
                Console.WriteLine("Your ticket level: " + b);
                Console.Write("How many tickets did you purchase?: ");
                string input2 = Console.ReadLine();
                int number = Convert.ToInt32(input2);
                int total;
                total = number * floor;
                Console.Write("\r\n");
                Console.Write("Your ticket: " + b + "\r\n");
                Console.Write("Ticket cost: $" + floor + "\r\n");
                Console.Write("Amount of tickets: " + input2 + "\r\n");
                Console.Write("Your total cost: $" + total + "\r\n");
                Console.Write("Press 'Enter' to exit");
                Console.Read();
            }
            if (input1 == "c")
            {
                Console.WriteLine("Your ticket level: " + c);
                Console.Write("How many tickets did you purchase?: ");
                string input2 = Console.ReadLine();
                int number = Convert.ToInt32(input2);
                int total = 0;
                total = number * tier1;
                Console.Write("\r\n");
                Console.Write("Your ticket: " + c + "\r\n");
                Console.Write("Ticket cost: $" + tier1 + "\r\n");
                Console.Write("Amount of tickets: " + input2 + "\r\n");
                Console.Write("Your total cost: $" + total + "\r\n");
                Console.Write("Press 'Enter' to exit");
                Console.Read();
            }
            if (input1 == "d")
            {
                Console.WriteLine("Your ticket level: " + d);
                Console.Write("How many tickets did you purchase?: ");
                string input2 = Console.ReadLine();
                int number = Convert.ToInt32(input2);
                int total;
                total = number * tier2;
                Console.Write("\r\n");
                Console.Write("Your ticket: " + d + "\r\n");
                Console.Write("Ticket cost: $" + tier2 + "\r\n");
                Console.Write("Amount of tickets: " + input2 + "\r\n");
                Console.Write("Your total cost: $" + total + "\r\n");
                Console.Write("Press 'Enter' to exit");
                Console.Read();
            }
            if (input1 == "e")
            {
                Console.WriteLine("Your ticket level: " + e);
                Console.Write("How many tickets did you purchase?: ");
                string input2 = Console.ReadLine();
                int number = Convert.ToInt32(input2);
                int total;
                total = number * tier3;
                Console.Write("\r\n");
                Console.Write("Your ticket: " + e + "\r\n");
                Console.Write("Ticket cost: $" + tier3 + "\r\n");
                Console.Write("Amount of tickets: " + input2 + "\r\n");
                Console.Write("Your total cost: $" + total + "\r\n");
                Console.Write("Press 'Enter' to exit");
                Console.Read();
            }

        }
    }
}