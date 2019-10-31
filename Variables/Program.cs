using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
        char char1 = 'h';

        float float1 = 5.1f;

        string string1 = "get";
        string string2 = "crunk";
        string string3 = string1 + " " + string2;

        byte byte1 = 1;
        byte byte2 = 2;
        //byte byte3 = byte1 + byte2;

        bool bool1 = false;
        bool bool2 = bool1;
        
        int int1 = 800;
        int int2 = 380;
        int int3 = (int1 - int2);
        
        Console.WriteLine(string3);
        Console.WriteLine(char1);
        Console.WriteLine(float1);
        Console.WriteLine(bool2); 
        Console.WriteLine(int3);      
        }
    }
}
