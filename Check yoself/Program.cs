using System;

namespace Check_yoself
{
    class Program
    {
        
        

        static void Main(string[] args)
        {
            int Aaaa = 0 + 1;
            int Bbbb = 0 - 1;
            Aaaa ++;
            Aaaa += 1;
            Console.WriteLine("A= " + Aaaa);
            Bbbb --;
            Bbbb -= 1;
            Console.WriteLine("B= " + Bbbb);
            
            if (Aaaa == 3 && Bbbb == -3)
            {
                Console.WriteLine("Is nice");
            }
            else if(Aaaa == 3 || Bbbb == -3)
            {
                Console.WriteLine("Almost there");
            }
            else
            {
                Console.WriteLine("You messed up pal");
            }
        }
    }
}
