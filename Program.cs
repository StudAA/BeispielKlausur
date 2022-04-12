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
                int auswahl = 0;
                Console.WriteLine("Menü Auswahl:");
                Console.WriteLine("1: Summe von Brüchen");
                Console.WriteLine("2: Zahlen Ausgeben");
                Console.WriteLine("3: Nullstellen der quadratischen Funktion");
                Console.WriteLine("4: Palindrom überprüfen");
                string auswahl0 = Console.ReadLine();
                if (auswahl0 != "1" && auswahl0 != "2" && auswahl0 != "3" && auswahl0 != "4")
                {
                    Console.WriteLine("Auswahl ist ungültig.");
                }
                else
                {
                    auswahl = Convert.ToInt32(auswahl0);
                }

                switch (auswahl)
                {
                    case 1:
                        Console.WriteLine("Es soll die Summe der Brüche von 1/a bis 1/b berechnet werden.");
                        Console.WriteLine("Geben Sie einen Wert für a ein:");
                        double a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Geben Sie einen Wert für b ein:");
                        double b = Convert.ToDouble(Console.ReadLine());
                        double summe = 0;
                        if (a < b)
                        {
                            for (double i = a; i <= b; i++)
                            {
                                summe += 1 / i;
                            }
                        }
                        else
                        {
                            for (double i = b; i <= a; i++)
                            {
                                summe += 1 / i;
                            }
                        }
                        Console.WriteLine("Die Summe der Brüche zwischen 1/" + a + " und 1/" + b + " ist:" + summe);
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
                        Console.WriteLine("Es sollen die Nullstellen einer quadratischen Funktion in allgemeiner Form berechnet werden.");
                        Console.WriteLine("ax^2 + bx + c");
                        Console.WriteLine("Geben Sie einen Wert für a an:");
                        double aa = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Geben Sie einen Wert für b an:");
                        double bb = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Geben Sie einen Wert für c an:");
                        double cc = Convert.ToDouble(Console.ReadLine());
                        double m = bb * bb - 4 * aa * cc;
                        if (m < 0)
                        {
                            Console.WriteLine("Es existieren keine reellen Nullstellen für die Gleichung: " + aa + "x^2 + " + bb + "x + " + cc);
                        }
                        else if (m == 0)
                        {
                            Console.WriteLine("Es existiert genau eine reelle Nullstelle für die Gleichung: " + aa + "x^2 + " + bb + "x + " + cc);
                            double x1 = (-bb + Math.Sqrt(m)) / 2 * aa;
                            Console.WriteLine("x = " + x1);
                        }
                        else if (m > 0)
                        {
                            Console.WriteLine("Es existieren zwei reelle Nullstellen für die Gleichung: " + aa + "x^2 + " + bb + "x + " + cc);
                            double x1 = (-bb + Math.Sqrt(m)) / 2 * aa;
                            double x2 = (-bb - Math.Sqrt(m)) / 2 * aa;
                            Console.WriteLine("x1 = " + x1 + " und x2 = " + x2);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Ein Wort soll darauf überprüft werden ob es ein Palindrom ist, d.h. ob es vorwärts wie rückwärts gelesen identisch ist.");
                        Console.WriteLine("Geben Sie ein Wort an:");
                        string wort = Console.ReadLine();
                        wort = wort.ToLower();
                        string rückwärts = "";
                        for (int i = wort.Length - 1; i >= 0; i--)
                        {
                            rückwärts += wort[i];
                        }
                        if (rückwärts == wort)
                        {
                            Console.WriteLine("Das Wort " + wort + " ist ein Palindrom.");
                        }
                        else
                        {
                            Console.WriteLine("Das Wort " + wort + " ist kein Palindrom.");
                        }
                        break;
                }


                Console.WriteLine("Neue Auswahl? (j/n)");
                wiederholen = Console.ReadLine();
                for (int i = 0; i < 1; i = 0)
                {
                    if (wiederholen != "j" && wiederholen != "J" && wiederholen != "n" && wiederholen != "N")
                    {
                        Console.WriteLine("Auswahl ist ungültig.");
                        Console.WriteLine("Neue Auswahl? (j/n)");
                        wiederholen = Console.ReadLine();
                    }
                    else
                    {
                        break;
                    }
                }
            } while (wiederholen == "J"  || wiederholen == "j");
        }
    }
}
