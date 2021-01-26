using System;

namespace Taschenrechner2
{
    class Program
    {

        static double fakultaet(int basis)
        {
            double ret = 1.0;
            double faktor = 1.0;

            for (int count = 0; count < basis; count++)
            {
                ret = ret * faktor;
                faktor = faktor + 1.0;
            }

            return ret;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(fakultaet(7));
        }
    }
}
