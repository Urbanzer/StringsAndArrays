using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik o tahed lauses Dont panic nulliga
            //asendab koik a tahed samas lauses 4-ga
            string dontP = "Don't Panic";

            dontP = dontP.Replace('o', '0');
            dontP = dontP.Replace('a', '4');
            Console.WriteLine(dontP);
        }
    }
}
