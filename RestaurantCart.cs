/*This program will allor a customer to add food to their cart and purchase.
 * It will show a receipt of all items selected, the tax cost and total.
 */
using System;

namespace ShoppingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define item names and prices
            string[] menuItems = { "Ham & Cheese Sandwich", "Tuna Sandwich", "Soup of the Day", "Baked Potato", "Salad", "Chips", "French Fries", "Bowl of Fruit" };
            double[] menuPrices = { 5.00, 6.00, 2.50, 3.00, 4.75, 2.00, 1.75, 2.50 };

            // Define variables for selected items, tax, and total
            string[] selectedItems = new string[8];
            int selectedItemCount = 0;
            double subtotal = 0.00;
            double taxRate = 0.05;
            double taxAmount = 0.00;
            double total = 0.00;

            // Display item menu and allow user to select up to 8 items
            Console.WriteLine("W e l c o m e   t o :");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("  B O B ' s  R E S T A U R A N T");
            Console.WriteLine("----------------------------------\r\n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine("{0}. {1} - ${2:F2}", i + 1, menuItems[i], menuPrices[i]);
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Enter item number you'd like to add \r\nor 0 to end selection:");
            int selection = Convert.ToInt32(Console.ReadLine());
            while (selection != 0 && selectedItemCount < 8)
            {
                if (selection >= 1 && selection <= 8)
                {
                    selectedItems[selectedItemCount] = menuItems[selection - 1];
                    subtotal += menuPrices[selection - 1];
                    selectedItemCount++;
                }
                Console.WriteLine("Would you like to add another item?\r");
                Console.WriteLine("Press '0' to end.");
                selection = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate tax and total
            taxAmount = subtotal * taxRate;
            total = subtotal + taxAmount;

            // Display receipt with selected items, tax, and total
            Console.WriteLine("\nReceipt:");
            Console.WriteLine("--------");
            for (int i = 0; i < selectedItemCount; i++)
            {
                Console.WriteLine("{0} - ${1:F2}", selectedItems[i], menuPrices[Array.IndexOf(menuItems, selectedItems[i])]);
            }
            Console.WriteLine("--------");
            Console.WriteLine("Subtotal: ${0:F2}", subtotal);
            Console.WriteLine("Tax: ${0:F2}", taxAmount);
            Console.WriteLine("Total: ${0:F2}", total);
            Console.WriteLine("Thank you! Enjoy your meal!");
            Console.ReadLine();
        }
    }
}
