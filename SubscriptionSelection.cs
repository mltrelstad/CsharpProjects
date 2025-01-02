using System;


class Program
{
    static void Main(string[] args)
    {
        bool isDone = false;

        // Define the subscription types and their costs
        string[] subscriptionTypes = { "Basic", "Premium", "Pro" };
        decimal[] subscriptionCosts = { 10.0m, 20.0m, 30.0m };

        // Define the mailing options and their costs
        string[] mailingOptions = { "Standard", "Priority", "Express" };
        decimal[] mailingCosts = { 0.0m, 5.0m, 10.0m };

        // Define the discount tiers and their discount percentages
        decimal[] discountTiers = { 50.0m, 100.0m, 150.0m };
        decimal[] discountPercentages = { 0.1m, 0.15m, 0.2m };

        while (!isDone)
        {
            // Prompt the user to enter their subscription type, mailing option, and number of months
            Console.WriteLine("Select a subscription type:");
            for (int i = 0; i < subscriptionTypes.Length; i++)
            {
                Console.WriteLine("{0}. {1} (${2})", i + 1, subscriptionTypes[i], subscriptionCosts[i]);
            }
            int subscriptionSelection = int.Parse(Console.ReadLine());

            Console.WriteLine("Select a mailing option:");
            for (int i = 0; i < mailingOptions.Length; i++)
            {
                Console.WriteLine("{0}. {1} (${2})", i + 1, mailingOptions[i], mailingCosts[i]);
            }
            int mailingSelection = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of months:");
            int numMonths = int.Parse(Console.ReadLine());

            // Calculate the cost of the subscription based on the user's selections and the number of months
            decimal subscriptionCost = subscriptionCosts[subscriptionSelection - 1];
            decimal mailingCost = mailingCosts[mailingSelection - 1];
            decimal totalCost = (subscriptionCost + mailingCost) * numMonths;

            // Apply discounts based on the total cost
            for (int i = 0; i < discountTiers.Length; i++)
            {
                if (totalCost >= discountTiers[i])
                {
                    decimal discountAmount = totalCost * discountPercentages[i];
                    totalCost -= discountAmount;
                    Console.WriteLine("Congratulations, you've qualified for a {0}% discount! You saved ${1}.", discountPercentages[i] * 100, discountAmount);
                    break;
                }
            }

            // Display the total cost to the user
            Console.WriteLine("Your total cost for {0} months is ${1}.", numMonths, totalCost);

            // Ask the user if they want to calculate again
            Console.WriteLine("Do you want to calculate again? (y/n)");
            string repeat = Console.ReadLine();
            if (repeat.ToLower() == "n")
            {
                isDone = true;
            }
        }
    }
}
