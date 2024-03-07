using System;

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the item from the shopping list:");
        string item = Console.ReadLine();

        switch (item.ToLower())
        {
            case "1":
                Console.WriteLine("You've ordered: Apple");
                break;
            case "2":
                Console.WriteLine("You've ordered: Banana");
                break;
            case "3":
                Console.WriteLine("You've ordered: Milk");
                break;
            case "4":
                Console.WriteLine("You've ordered: Bread");
                break;
            case "5":
                Console.WriteLine("You've ordered: Eggs");
                break;
            default:
                Console.WriteLine("The item ordered is not in the shopping list.");
                break;
        }

        Console.ReadLine();
    }
}
