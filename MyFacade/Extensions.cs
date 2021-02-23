using System;

namespace MyFacade
{
    public class Extensions
    {
        static public double ConsoleReadInt()
        {
            double ret = 0;
            string input = Console.ReadLine();
            ret = double.Parse(input);
            return ret;
        }

        static public double ConsoleReadInt(bool checkErrors, double min= double.MinValue, double max= double.MaxValue, string formatErrorMessage= null)
        {
            double ret = 0;
            bool ok = false;
            while( !ok)
            {
                try
                {
                    ret = ConsoleReadInt();
                    if( ret< min)
                    {
                        Console.WriteLine("Zahl muss gösser {0} sein!", min);
                    }
                    else
                    {
                        if( ret> max)
                        {
                            Console.WriteLine("Zahl muss kleiner {0} sein!", max);
                        }
                        else
                        {
                            ok = true;
                        }
                    }
                }
                catch( Exception)
                {
                    string message = "Nur Ganzzahlen sind erlaubt!";
                    if( formatErrorMessage!= null)
                    {
                        message = formatErrorMessage;
                    }
                    Console.WriteLine(message);
                }
            }

            return ret;
        }
    }
}
