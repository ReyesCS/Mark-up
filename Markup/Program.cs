using System;

namespace Markup
{
    class Program
    {
        static void Main(string[] args)
        {
            double itemPrice;
            DisplayInstructions();
            itemPrice = GetInput();
            ProduceTable(itemPrice);
            Console.ReadKey();
        }
        public static void DisplayInstructions()
        {
            Console.WriteLine("********************************************");
            Console.WriteLine("This application shows the retail price");
            Console.WriteLine("of an item using different markup percentages.");
            Console.WriteLine("\nYou will be asked to enter the wholesale price.");
            Console.WriteLine("\n\n\nPress any key when you are ready to begin....");
            Console.ReadKey();
        }
        public static double GetInput()
        {
            double price;
            string inValue;
            Console.Clear();
            Console.Write("Please enter the wholesale price of the item: ");
            inValue = Console.ReadLine();
            while (double.TryParse(inValue, out price) == false)
            {
                Console.Write("\nInvalid data entered - " +
                "Please re-enter the wholesale price of the item: ");
                inValue = Console.ReadLine();
            }
            return price;
        }
        public static void ProduceTable(double itemPrice)
        {
            PrintHeading();
            Console.Write("{0,-20:C}", itemPrice);
            for (double percentage = 0.05; percentage < 0.10; percentage += 0.01)
            {
                Console.Write("{0,10:C}", (itemPrice + (percentage * itemPrice)));
            }
        }
        public static void PrintHeading()
        {
            Console.Clear();
            Console.WriteLine("{0,-20} {1,45}", "Item", "Percentage Increase");
            Console.Write("{0,-20}", "Price");
            for (double percentage = 0.05; percentage < 0.10; percentage += 0.01)
            {
                Console.Write("{0,10:F2}", percentage);
            }
        }
    }
}
