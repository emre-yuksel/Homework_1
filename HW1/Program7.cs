using System;

class Program7
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of the students: ");
        int numberOfStudents = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfStudents; i++)
        {
            Console.WriteLine($"\nStudent {i + 1}:");
            Console.Write("Enter the student's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter the student's surname: ");
            string surname = Console.ReadLine();

            double totalGrade = 0;          
            for (int j = 0; j < 3; j++)             // Using for loop to scan the grades of 3 exams
            {
                Console.Write($"Enter the student's grade for exam {j + 1}: ");
                double grade = double.Parse(Console.ReadLine());
                totalGrade += grade;
            }

            double averageGrade = totalGrade / 3;
            Console.WriteLine($"Student with the name {name} {surname} has an average grade of {averageGrade}");
        }
    }
}
