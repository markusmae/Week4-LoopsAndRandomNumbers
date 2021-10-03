using System;

namespace GuessingGameThreeTries
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
            //katsete arv on 3, kui see ületatakse siis võidab arvuti
            //programm genereerib juhusliku numbri vaid üks kord
            int i = 0;
            
            while(i < 3)
            {
                Console.WriteLine("Paku, mis numbrile ma mõtlen. Sul on kokku 3 katset.");
                int kasutajanr = Convert.ToInt32(Console.ReadLine());

                if(kasutajanr == number)
                {
                    Console.WriteLine($"Sinu pakutud number {number} oli õige. Palju õnne, täna võitsid sina!");
                    break;
                }

                else
                {
                    i++;
                    Console.WriteLine($"Sellele numbile ma kahjuks ei mõelnud. Paku uuesti, sul on veel {3-i} katset.");
                }

            }
        }
    }
}
