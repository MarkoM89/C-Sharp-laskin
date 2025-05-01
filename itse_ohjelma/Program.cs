
namespace Laskin
{
    public class Program
    {
        public static void Main()
        {

            LaskuToimitus laskin = new LaskuToimitus();
            char merkki = ' ';
            double luku1, luku2;
            luku1 = luku2 = -1;
            bool virhe = true;


            //TryParse 2:33:00?
            //do while?
            //dotnet new --list
            while (merkki == '-')
            {

            }
            while (virhe)
            {
                virhe = false;
                Console.WriteLine("Syötä luku 1");

                try
                {
                    luku1 = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ylimääräisiä merkkejä, pelkkä luku kiitos.");
                    virhe = true;
                }
            }
            virhe = true;

            while (merkki != '+' && merkki != '-' && merkki != '*' && merkki != '/')
            {
                Console.WriteLine("\nValitse toiminto: +, -, *, /\n");
                merkki = Console.ReadKey().KeyChar;
            }


            Console.WriteLine("\nLaskutoimitus: " + merkki);

            while (virhe)
            {
                virhe = false;
                Console.WriteLine("Syötä luku 2");

                try
                {
                    luku2 = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ylimääräisiä merkkejä, pelkkä luku kiitos.");
                    virhe = true;
                }

                if (luku2 == 0 && merkki == '/')
                {
                    Console.WriteLine("Nollalla jako ei ole mahdollista.");
                    virhe = true;
                }
            }

            Console.WriteLine("\nTulos:");

            if (merkki == '+')
            {
                Console.WriteLine(luku1 + " " + merkki + " " + luku2 + " = " + laskin.Lisaa(luku1, luku2));
            }
            else if (merkki == '-')
            {
                Console.WriteLine(luku1 + " " + merkki + " " + luku2 + " = " + laskin.Vahenna(luku1, luku2));

            }
            else if (merkki == '*')
            {
                Console.WriteLine(luku1 + " " + merkki + " " + luku2 + " = " + laskin.Kerro(luku1, luku2));

            }
            else if (merkki == '/')
            {
                Console.WriteLine(luku1 + " " + merkki + " " + luku2 + " = " + laskin.Jaa(luku1, luku2));

            }


            //Console.WriteLine(Potenssi(4, 3));


        }

        static int Potenssi(int kantaluku, int korotus)
        {

            int tulos = 1;

            for (int i = 1; i <= korotus; i++)
            {
                tulos *= kantaluku;
            }

            return tulos;
        }

    }
}
