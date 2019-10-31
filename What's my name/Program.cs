using System;

namespace What_s_my_name
{
    class Program
    {
        static void Main(string[] args)
        {
            string naam;
            string leeftijd;
            string location;
            string postalCode;
            string hobby;
            string favoriteFood;

            Console.WriteLine("Enter your name");
            naam = Console.ReadLine();

            Console.WriteLine("Enter your age");
            leeftijd = Console.ReadLine();

            Console.WriteLine("What city do you live in?");
            location = Console.ReadLine();

            Console.WriteLine("What is your postal code?");
            postalCode = Console.ReadLine();

            Console.WriteLine("What is your biggest hobby?");
            hobby = Console.ReadLine();

            Console.WriteLine("Last question, what is your favorite food?");
            favoriteFood = Console.ReadLine();

            Console.WriteLine("Hello "+ naam + ". I see that you are " + leeftijd + " Years old, live in " + location + " and have the postal code " + postalCode + ". I've also learned that your biggest hobby is " + hobby + " and that your favorite food is " + favoriteFood);
        }
    }
}
