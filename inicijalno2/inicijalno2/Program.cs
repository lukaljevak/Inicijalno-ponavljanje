using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inicijalno2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite niz znakova:");
            string niz = Console.ReadLine();
            string rezultat = niz.Replace(' ', '_');
            Console.WriteLine("Rezultat: " + rezultat);
            Console.ReadKey();
        }
    }
}
