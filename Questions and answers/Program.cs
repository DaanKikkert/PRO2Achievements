using System;

namespace Questions_and_answers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How are you today?");
            string answer1 = Console.ReadLine();

            Console.WriteLine("What did you do yesterday?");
            string answer2 = Console.ReadLine();

            Console.WriteLine("What have you got planned for the weekend?");
            string answer3 = Console.ReadLine();
            
            Console.WriteLine("Your answers:");
            Console.WriteLine("Q1. How are you today?: " + answer1);
            Console.WriteLine("Q2. What did you do yesterday?: " + answer2);
            Console.WriteLine("Q3. What have you got planned for the weekend? " + answer3);
        }
    }
}