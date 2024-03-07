using System;

// As far as I know, a perfect number is a positive integer number 
// who is equal to the sum of its positive divisors, excluding the number itself.

class Program5
{
        static void Main(string[] args)
{
    int number, sum = 0, n;
    Console.Write("Enter the number you would like to check whether it's a perfect number or not: ");
    number = int.Parse(Console.ReadLine());
    n = number;
    for (int i = 1; i < number; i++)
    {
        if (number % i == 0)
        {
            sum = sum + i;
        }
    }
    if (sum == n)
    {
        Console.WriteLine("\n The number you entered is a perfect number");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine("\n The number you entered is not a perfect number");
        Console.ReadLine();
    }
}
}