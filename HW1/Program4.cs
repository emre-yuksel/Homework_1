using System;

class Program4
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int randomNumber = random.Next(1, 11); // Generates a random number between 1 and 10

        Console.WriteLine("I've picked a number between 1 and 10. Can you guess it? Please enter your guess in 'integer' format.");

        int guess;
        int attempts = 0;

        do
        {
            Console.Write("Enter your guess: ");
            guess = int.Parse(Console.ReadLine());  // I converted the scanned string into an integer number
            attempts++;

            if (guess < randomNumber)
            {
                Console.WriteLine("Go up! Try again.");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Go down! Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the number {randomNumber} in {attempts} attempts!");
            }
        } while (guess != randomNumber);
    }
}
