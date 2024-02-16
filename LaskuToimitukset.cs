

namespace Laskin
{

    class LaskuToimitus
    {

        private double tulos;

        public double Lisaa(double luku1, double luku2)
        {
            tulos = luku1 + luku2;

            return tulos;
        }

        public double Vahenna(double luku1, double luku2)
        {
            tulos = luku1 - luku2;

            return tulos;
        }

        public double Kerro(double luku1, double luku2)
        {
            tulos = luku1 * luku2;

            return tulos;
        }

        public double Jaa(double luku1, double luku2)
        {
            tulos = luku1 / luku2;

            return tulos;
        }

    }
}