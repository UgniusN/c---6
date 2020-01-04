using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pirmasSarasas = new List<int>() { 1, 2, 4, 8 };
            List<int> antrasSarasas = new List<int>() { 2, 4, 8 };
            bool contain = false;
            foreach (int skaicius in antrasSarasas)
            {
                if (pirmasSarasas.Contains(skaicius))
                {
                    contain = true;
                }
                else
                {
                    contain = false;
                    break;
                }
            }
            if (contain == true)
            {
                Console.WriteLine("Taip, antrasSarasas yra pirmasSarasas dalis");
            }
            else
            {
                Console.WriteLine("Ne, antrasSarasas nera pirmasSarasas dalis");
            }
            Console.Read();
        }
    }
}
