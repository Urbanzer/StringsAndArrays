using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab homset
            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };


            Random rnd = new Random();
            int userNumber = rnd.Next(0, 4);

            Console.WriteLine($"Tomorrow you will {predictions[userNumber]}.");
        }
    }
}
