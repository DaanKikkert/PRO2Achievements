using System;

namespace One_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bigOleListOfGames =
            {"#1: Monster Hunter World", 
            "#2: Team Fortress 2", 
            "#3: Legend of Zelda: Breath of the wild", 
            "#4: Super Mario Oddysey", 
            "#5: Bloodborne" , 
            "#6: Rayman 3", 
            "#7: Legend of Zelda: Wind Waker", 
            "#8: Smash Bros Ultimate", 
            "#9; Bloodborne", 
            "#10: League of Legends"};

            Console.WriteLine("Here is a list of my favorite video games:");
            foreach (var game in bigOleListOfGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
