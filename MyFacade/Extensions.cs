using System;

namespace MyFacade
{
    public class Extensions
    {
        static public int ConsoleReadInt()
        {
            int ret = 0;
            string input = Console.ReadLine();
            ret = int.Parse(input);
            return ret;
        }
    }
}
