using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri (1-10)
            Random rnd = new Random();
            int number = rnd.Next(1, 11);

            //kasutaja peab numbrit ära arvama
            //kui kasutaja suutis numbri ära arvata, siis ta on mängu võitnud
            //katsete arv on piiramatu
            //programm genereerib juhusliku numbri vaid üks kord
            bool loopActive = true;

            while(loopActive)
            {
                Console.WriteLine("Paku mis numbrile ma mõtlen.");
                int kasutajanr = Convert.ToInt32(Console.ReadLine());

                if(kasutajanr == number)
                {
                    Console.WriteLine($"Õige vastus, number millele mõtlesin oli {number}.");
                    loopActive = false;
                }

                else
                {
                    Console.WriteLine("Vale number proovi uuesti.");
                }

            }
        }
    }
}
