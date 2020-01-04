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
            bool ciklas = false;
            string ivedamasPazimys;
            int grade;
            int pozicija;
            string ivedamapozicija;
            double vidurkis = 0;
            while (!ciklas)
            {
                Console.WriteLine("Iveskite pasirinkima: 0 - papildyti, 1 - istrinti, 2 - iterpti, 3 - parodyti pazymiu vidurki, 4 - iseiti is programos");
                String ivestasSkaicius = Console.ReadLine();
                pasirinkimas = Convert.ToInt32(ivestasSkaicius);
                switch (pasirinkimas)
                {
                    case 0:
                        Console.WriteLine("Iveskite pazymi kuri norite prideti");
                        ivedamasPazimys = Console.ReadLine();
                        grade = Convert.ToInt32(ivedamasPazimys);
                        pazymiai.Add(grade);
                        break;
                    case 1:
                        Console.WriteLine("Iveskite pazymio pozicija kuria norite pasalinti");
                        ivedamapozicija = Console.ReadLine();
                        pozicija = Convert.ToInt32(ivedamapozicija);
                        pazymiai.RemoveAt(pozicija);
                        break;
                    case 2:
                        Console.WriteLine("Iveskite pazymio pozicija i kuria norite prideti pazymi");
                        ivedamapozicija = Console.ReadLine();
                        pozicija = Convert.ToInt32(ivedamapozicija);
                        Console.WriteLine("Iveskite pazymi kuri norite prideti");
                        ivedamasPazimys = Console.ReadLine();
                        grade = Convert.ToInt32(ivedamasPazimys);
                        pazymiai[pozicija] = grade;
                        break;
                    case 3:
                        foreach(int pazimys in pazymiai)
                        {
                            vidurkis += pazimys;
                        }
                        vidurkis = vidurkis / pazymiai.Count;
                        Console.WriteLine("Pazymiu vidurkis: {0}", vidurkis);
                        break;
                    case 4:
                        ciklas = true;
                        break;
                }
            }
        }
    }
}
