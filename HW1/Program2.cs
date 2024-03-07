using System;

class Program2
{
    static void Main(string[] args)
    {
        double totalShoppingAmount = 0;
        
        Console.WriteLine("How many products do you want to buy?");
        int numProducts = Convert.ToInt32(Console.ReadLine());      // I had to use convert.toint32 method
                                                                    // since we get a string from user

        for (int i = 1; i <= numProducts; i++)
        {
            Console.Write("Enter the price of product " + i + ": ");
            double price = Convert.ToDouble(Console.ReadLine());        // I used 

            totalShoppingAmount += price;
        }

        Console.WriteLine("Total shopping amount: TL" + totalShoppingAmount);
    }
}
