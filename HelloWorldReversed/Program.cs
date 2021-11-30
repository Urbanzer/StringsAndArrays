using System;

namespace HelloWorldReversed
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string firstName = "Hello";
            string lastName = "World";

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            for (int i = fullName.Length - 1; i >= 0; i--)
            {
                Console.Write(fullName[i]);
            }
        }
    }
}
