using System;

namespace Kretanje
{
    class Program
    {
        static void Main(string[] args)
        {
            int trenutaSoba = 1;
            int brojSoba = 5;

            do
            {
                Console.Clear();
                int brojac = 1;
                while(brojac <= brojSoba)
                {
                    if (trenutaSoba == brojac)
                    {
                        Console.Write("[*]");
                    }else
                    {
                        Console.Write("[]");
                    }
                    if (brojac < brojSoba)
                    {
                        Console.Write("-");
                    }
                    brojac++;
                }
                Console.WriteLine();
                Console.Write("Smer?");
                string unos = Console.ReadKey().KeyChar.ToString();
                if (unos == "d")
                {
                    trenutaSoba++;
                }else if (unos == "a")
                {
                    trenutaSoba--;
                }
            } while (true);

        }
    }
}
