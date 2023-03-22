using System;
namespace metoder
{
    class program
    {
        static void Main(string[] args)
        {
            Primtal();
        }
        static void Primtal()
        {
            Console.WriteLine("Skriv ett valfrit heltal");
            string a =Console.ReadLine();
            int b = int.Parse(a);
            Console.WriteLine(" ");
            if (b % 3 == 0 & b!=3 || b % 2 == 0 & b!=2 || b % 5 ==0)
            {
                Console.WriteLine("Talet du skrev in är inte ett primtal");
            }

           else if (b % 3 != 0 || b == 3 & b % 2 != 0 || b == 2)
            {
                Console.WriteLine("Talet du skrev in är ett primtal");
            }
           
        }
    }
}
