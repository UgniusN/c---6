using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skaiciai = new List<int>();
            var skaicius = new Random();

            
            for(int i=0; i<10; i++)
            {
                skaiciai.Add(skaicius.Next(2, 10000));
            }
            foreach(int number in skaiciai)
            {
                if (number % 2 == 0)
                    Console.WriteLine(number);
            }
            Console.Read();
        }

    }
}
