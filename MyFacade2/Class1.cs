using System;

namespace MyFacade2
{
    public class Extensions2
    {
        static public int ReadInt()
        {
            int ret = 0;
            string input = Console.ReadLine();
            ret = int.Parse(input);

            return ret;
        }
    }
}
