using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalni4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;

            Console.WriteLine("Unesite dužinu stranice x:");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite dužinu stranice y:");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite dužinu stranice z:");
            z = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0 && z > 0)
            {
                if (provjera(x, y, z))
                {
                    Console.WriteLine("Stranice čine pravokutni trokut.");
                }
                else
                {
                    Console.WriteLine("Stranice ne čine pravokutni trokut.");
                }
            }
            else
            {
                Console.WriteLine("Svi iznosi moraju biti veći od 0.");
            }
            Console.ReadKey();
        }

        static bool provjera(int a, int b, int c)
        {
            return (a * a + b * b == c * c) ||
                   (a * a + c * c == b * b) ||
                   (b * b + c * c == a * a);
        }
        
    }
}
