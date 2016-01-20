using System;


namespace t1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas();
            harvia.Temp = 25;
            int Valinta = 0;
            int Poistuminen = 1;
            Console.WriteLine("\n\n\n  1. Kuumaa\n  2. Kylmaa\n  3. Poistu\n\n");
            do
            {
                
                Valinta = int.Parse(Console.ReadLine());
                switch (Valinta)
                {
                    case 1:
                        harvia.Kuumaa();
                        harvia.Tarkistus();
                        break;
                    case 2:
                        harvia.Kylmaa();
                        harvia.Tarkistus();
                        break;
                    case 3:
                        Poistuminen = 0;
                        break;
                }
            } while (Poistuminen != 0);

            
            Console.WriteLine("\n\n\n");
        }

        class Kiuas
        {
            public int Temp { get; set; }

            public void Kuumaa()
            {
                Temp += 1;
            }
            public void Kylmaa()
            {
                Temp -= 1;
            }
        /*    
            public void Valikko()
             {
             int Valinta = 0;
             int Poistuminen = 1;
             do
             {

                 Valinta = int.Parse(Console.ReadLine());
                 switch (Valinta)
                 {
                     case 1:
                         harvia.Kuumaa();
                         harvia.Tarkistus();
                         break;
                     case 2:
                         harvia.Kylmaa();
                         harvia.Tarkistus();
                         break;
                     case 3:
                         Poistuminen = 0;
                         break;
                 }
             } while (Poistuminen != 0);
             }
             */
            public void Tarkistus()
            {
                Console.WriteLine("  Lampotila on " + Temp + " astetta." );
            }
        }
        
        
    }
}
