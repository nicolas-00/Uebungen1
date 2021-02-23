using System;
using MyFacade;

namespace Taschenrechner
{
    class Program
    {

        static double Fakultaet( double basis)
        {
            double ret = 1.0;
            double factor = 1.0;

            for( double cnt = 0; cnt< basis; cnt++)
            {
                ret = ret * factor;
                factor = factor + 1.0;
            }

            return ret;
        }

        static double SquareRoot( double value)
        {

            throw new NotImplementedException();
        }


        static void Main()
        {
            while( true)
            {
                Console.WriteLine("Was möchtest du tun?");
                Console.WriteLine("1: Fakultät berechnen");
                Console.WriteLine("2: Quadratzahl berechnen");
                Console.WriteLine("3: Summe berechnen");
                Console.WriteLine("4: Kreisflaeche berechnen");
                Console.WriteLine("5: Vierte Potenz berechnen");
                Console.WriteLine("6: 17-Fache berechnen");
                Console.Write("Deine Wahl: ");
                double wahl = Extensions.ConsoleReadInt(true, 1, 6);
                double zahl = 0;
                switch ( wahl)
                {
                    case 1:
                        Console.Write("Gib die Zahl ein, von welcher du die Fakultät berechnen möchtetst: ");
                        zahl = Extensions.ConsoleReadInt(true, 0, 170);
                        Console.WriteLine(Fakultaet(zahl));
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.Write("Gib die Zahl ein, von welcher du die Quadratzahl berechnen möchtetst: ");
                        zahl = Extensions.ConsoleReadInt(true, -50000, 50000);
                        Console.WriteLine(zahl*zahl);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Gib die Zahl ein, von welcher du die Summe berechnen möchtest: ");
                        zahl = Extensions.ConsoleReadInt(true, 0, 100000000);
                        Console.WriteLine(zahl + zahl);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Gib eine Zahl ein, von welcher du die Fläche für einen Kreis berechnen möchtest: ");
                        zahl = Extensions.ConsoleReadInt(true, 0, 50000);
                        Console.WriteLine(Math.PI * zahl * zahl);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine("Gib eine Zahl ein, von welcher du die vierte Potenz berechnen möchtest: ");
                        zahl = Extensions.ConsoleReadInt(true, 0, 50000);
                        Console.WriteLine(zahl * zahl * zahl * zahl);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine("Gib eine Zahl ein, von welcher du das 17-Fache berechnen möchtest: ");
                        zahl = Extensions.ConsoleReadInt(true, 0, 50000);
                        Console.WriteLine(zahl * 17);
                        Console.WriteLine();
                        break;
                    default:
                        throw new Exception("Error");
                }

            }

        }

        static void Main1(string[] args)
        {
            while( true)
            {
                double zahl = 0;
                bool ok = false;
                while( !ok)
                {
                    Console.Write("Gib die Zahl ein, von welcher du die Fakultät berechnen möchtetst: ");
                    zahl = Extensions.ConsoleReadInt(true, 0, 170);
                    //if (zahl > 170)
                    //{
                    //    ok = false;
                    //    Console.WriteLine("Die Zahl ist zu hoch! Probiers nochmals!");
                    //}
                    //else
                    {
                        ok = true;
                    }
                }
                Console.WriteLine(Fakultaet(zahl));
                Console.WriteLine();
            }
        }
    }
}
