using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu h, o, l tahte Hello World


            string firstName = "Hello";
            string lastName = "World";

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'h')
                {
                    hCounter++;
                }

            }

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'o')
                {
                    oCounter++;
                }

            }

            for (int i = 0; i < fullName.Length; i++)
            {
                if (fullName[i] == 'l')
                {
                    lCounter++;
                }

            }

            Console.WriteLine($"Hello Worldis on {hCounter} 'h' tahte, {oCounter} 'o' tahte ja {lCounter} 'l' tahte.");


        }
    }
}
