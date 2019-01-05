using System;

namespace switchStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your grade - example --> A+, A, B");
            string userGrade = Console.ReadLine();

            switch (userGrade)
            {
                case "A+":
                case "A":    
                    Console.WriteLine("Distinction");
                    break;

                case "B+":
                case "B":
                    Console.WriteLine("Not at the top, but still near the top.");
                    break;

                case "C":
                    Console.WriteLine("You passed but you'll need to have a good personality or wealthy parents with connections to make it far.");
                    break;

                default:
                    Console.WriteLine("Failure Alert!");
                    break;
            }
        }
    }
}
