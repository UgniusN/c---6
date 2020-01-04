using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> vardai = new List<String> { "Ugnius", "Petras", "Juozas", "Audrius", "Nojus" };
            vardai.Add("Napoleonas");
            vardai.Add("Asterisas");
            vardai.RemoveAt(2);
            vardai[vardai.IndexOf("Napoleonas")] = "Kleopatra";

            foreach (string vardas in vardai)
            {
                Console.WriteLine(vardas);
            }

            Console.Read();
        }
    }
}
