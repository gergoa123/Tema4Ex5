using System;

//Ex5 Scrieti o functie recursiva care va calcula suma numerelor de la 1 pana la n,apelati - o si afisati-i rezultatul. 

namespace Tema4Ex5
{
    class Program
    {
        static int Sum(int n)
        {
            
            if (0 == n )
            {
                return 0;
            }
            return n + Sum(n - 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti n = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(Sum(a));
        }

        
    }
}
