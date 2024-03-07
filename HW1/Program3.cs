using System;

// Do and While loops are control flow statements in C# and unlike While loop,
// we execute the codes in Do block for sure

class Program3
{
    static void Main(string[] args)
    {
        int count = 0;

        Console.WriteLine("While loop:");
        while (count < 5)
        {
            Console.WriteLine("Count is: " + count);
            count++;
        }

        int count2 = 0;
        Console.WriteLine("\nDo-While loop:");
        do
        {
            Console.WriteLine("Count is: " + count2);
            count2++;
        }
        while (count2 < 5);
    }
}
