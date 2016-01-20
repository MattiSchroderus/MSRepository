using System;


namespace t1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas();
            harvia.Temp = 25;
            harvia.Kuumaa();
            harvia.Tarkistus();

        }

        class Kiuas
        {
            public int Temp { get; set; }

            public void Kuumaa()
            {
                Temp += 3;
            }
            public void Kylmaa()
            {
                Temp -= 3;
            }
            public void Tarkistus()
            {
                Console.WriteLine("  Lampotila on " + Temp + " astetta." );
            }
        }
    }
}
