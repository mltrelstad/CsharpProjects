using System;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;

        // Subscriptions
        string[] subType = { "Ice Cream", "Bacon", "Peanut Butters" };
        decimal[] subCost = { 12, 15, 17 };

        // Shipping
        string[] shipping = { "Regular", "Expedited", "Overnight" };
        decimal[] shipCost = { 5, 10, 30 };

    // Discounts
        decimal[] discountTiers = { 50, 100, 150 };
        decimal[] discountPercent = { 0.05m, 0.07m, 0.10m };

        while (!done)
        {
    // Subcriptions

            Console.WriteLine("Welcome to FLAVORS of the Month!");
            Console.WriteLine("================================\r\n");
            Console.WriteLine("Select a subscription type:");

            for (int i = 0; i < subType.Length; i++)
            {
                Console.WriteLine("{0}. {1} (${2})", i + 1, subType[i], subCost[i]);
            }
            int subscriptionSelection = int.Parse(Console.ReadLine());

    // Shipping
            Console.WriteLine("Select a shipping option:");
            for (int i = 0; i < shipping.Length; i++)
            {
                Console.WriteLine("{0}. {1} (${2})", i + 1, shipping[i], shipCost[i] );
            }
            int mailingSelection = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of months:");
            int months = int.Parse(Console.ReadLine());

     // Calculation
            decimal subscriptionCost = subCost[subscriptionSelection - 1];
            decimal mailingCost = shipCost[mailingSelection - 1];
            decimal totalCost = (subscriptionCost + mailingCost) * months;

     // Discounts
            for (int i = 0; i < discountTiers.Length; i++)
            {
                if (totalCost >= discountTiers[i])
                {
                    decimal discountAmount = totalCost * discountPercent[i];
                    totalCost -= discountAmount;
                    Console.WriteLine("Congratulations, you've qualified for a {0}% discount! \nYou saved ${1}.", discountPercent[i] * 100, discountAmount);
                    break;
                }
            }

    // Total Cost
            Console.WriteLine("Your total cost for {0} months is ${1}.", months, totalCost + "\r\n");

    // Run again?
            Console.WriteLine("Would you like to make another purchase? (y/n)");
            string repeat = Console.ReadLine();
            if (repeat.ToLower() == "n")
            {
                done = true;
            }
        }
    }
}
