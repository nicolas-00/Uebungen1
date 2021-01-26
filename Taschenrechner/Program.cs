using System;

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
            Console.WriteLine("Hello World!");
            Console.WriteLine(Fakultaet(5));
        }
    }
}
