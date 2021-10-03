using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm genereerib juhusliku numbri (1-10)
            //kui genereeritud number on 5, programm lõpetab töö ja soovib kasutajale "kena päeva"
            //kui genereeritud number on midagu muud, siis programm jätkab oma tööd

            Random rnd = new Random();
            int i = 0;

            while(i != 5)
            {
                int MyRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik number on {MyRandomNumber}");

                if(MyRandomNumber == 5)
                {
                    i = MyRandomNumber;
                }

                Console.WriteLine("Kena päeva!");
            }

            

            
        }
    }
}
