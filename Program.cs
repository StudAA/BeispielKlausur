using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeispielKlausur
{
    class Program
    {
        static void Main(string[] args)
        {
            string wiederholen;
            do
            {
                Console.WriteLine("Menü Auswahl:");
                Console.WriteLine("1: Summe von Brüchen");
                Console.WriteLine("2: Zahlen Ausgeben");
                Console.WriteLine("3: ");
                Console.WriteLine("4: ");
                int auswahl = Convert.ToInt32(Console.ReadLine());

                switch (auswahl)
                {
                    case 1:
                        Console.WriteLine("Es soll die Summe der Brüche von 1/a bis 1/b berechnet werden.");
                        Console.WriteLine("Geben Sie einen Wert für a ein:");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Geben Sie einen Wert für b ein:");
                        int b = Convert.ToInt32(Console.ReadLine());
                        float summe = 0;
                        if (a < b)
                        {
                            for (float i = a; i <= b; i++)
                            {
                                summe += 1 / i;
                            }
                        }
                        else
                        {
                            for (float i = b; i <= a; i++)
                            {
                                summe += 1 / i;
                            }
                        }
                        Console.WriteLine("Die Summe der Brüche zwischen 1/" + a + "und 1/" + b + "ist:" + summe);
                        break;

                    case 2:
                        Console.WriteLine("Es sollen alle Zahlen von 1 bis zu einer Grenze g ausgegeben werden, wobei jedesmal wenn eine Zahl die Ziffer vier enthält oder durch vier teilbar ist ein Hinweis erscheinen soll.");
                        Console.WriteLine("Geben Sie eine Grenze an:");
                        int g = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i<=g; i++)
                        {
                            Console.WriteLine(i);
                            if (i%4==0)
                            {
                                Console.WriteLine("Diese Zahl ist durch 4 teilbar.");
                            }
                            string str = i.ToString();
                            for (int f=0; f<str.Length; f++)
                            { 
                                if (str[f]=='4')
                                {
                                    Console.WriteLine("Diese Zahl enthält die Ziffer 4.");
                                }
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("sollen die Nullstellen einer quadratischen Funktion in allgemeiner Form berechnet werden.");
                        break;

                    case 4:

                        break;

                    default:
                        Console.WriteLine("Auswahl ungültig!");
                        break;
                }



                wiederholen = Console.ReadLine();
            } while (wiederholen == "J"  || wiederholen == "j");
        }
    }
}
