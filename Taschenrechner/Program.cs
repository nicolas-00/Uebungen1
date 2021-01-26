using System;
using MyFacade;

namespace Taschenrechner
{
    class Program
    {

        static double Fakultaet( int basis)
        {
            double ret = 1.0;
            double factor = 1.0;

            for( int cnt = 0; cnt< basis; cnt++)
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

        static void Main(string[] args)
        {
            while( true)
            {
                int zahl = 0;
                bool ok = false;
                while( !ok)
                {
                    Console.Write("Gib die Zahl ein, von welcher du die Fakultät berechnen möchtetst: ");
                    try
                    {
                        zahl = Extensions.ConsoleReadInt();
                        ok = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Das ging daneben! Probiers nochmals!");
                    }
                }
                Console.WriteLine(Fakultaet(zahl));
                Console.WriteLine();
            }
        }
    }
}
