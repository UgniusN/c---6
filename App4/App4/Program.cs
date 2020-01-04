using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();
            int pasirinkimas;
            for(; ; )
            {
                Console.WriteLine("Iveskite pasirinkima: 0 - papildyti, 1 - istrinti, 2 - iterpti, 3 - parodyti pazymiu vidurki, 4 - iseiti is programos");
                String ivestasSkaicius = Console.ReadLine();
                pasirinkimas = Convert.ToInt32(ivestasSkaicius);
                switch(pasirinkimas)
            }
        }
    }
}
