using System;
namespace primtal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal du vill under söka");
            int tal = int.Parse(Console.ReadLine());
            Primtal(tal);
        }

        static void Primtal(int tal)
        {
            int deltal = 0;
            for (int i = 2; i < tal; i++)
            {
                if (tal % i == 0)
                {
                    deltal++;
                }
            }
            if (deltal == 0)
            {
                Console.WriteLine("Ditt tal är ett primtal");
            }
            else
            {
                Console.WriteLine("Ditt tal är inte ett primtal");
            }
        }
    }
}