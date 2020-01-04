using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> Studentai = new List<String>() { "Ugnius", "Andrius", "Jonas", "Petras", "Audrius" };
            List<String> pavelaveStudentai = new List<String> { "Antanas", "Gvidas", "Erikas", "Nojus " };
            List<String> bendrasSarasas = new List<String>();
            foreach(string vardas in pavelaveStudentai)
            {
                bendrasSarasas.Add(vardas);
            }
            foreach(string vardas in Studentai)
            {
                bendrasSarasas.Add(vardas);
            }
            bendrasSarasas.Sort();
            bendrasSarasas.ForEach(delegate(String vardas) 
            {
                Console.WriteLine(vardas); 
            });
            bendrasSarasas.ForEach(vardas => Console.WriteLine(vardas) );
            Console.Read();
        }
    }
}
