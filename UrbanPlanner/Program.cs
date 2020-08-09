using System;

namespace UrbanPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneFiveZero = new Building("5150 Van Halen Blvd");
            FiveOneFiveZero.Width = 100;
            FiveOneFiveZero.Depth = 50;
            FiveOneFiveZero.Stories = 10;

            Building TwoOneFour = new Building("214 Main Street");
            TwoOneFour.Width = 50;
            TwoOneFour.Depth = 50;
            TwoOneFour.Stories = 4;

            Building OneZeroOne = new Building("101 NewFound Rd.");
            OneZeroOne.Width = 30;
            OneZeroOne.Depth = 25;
            OneZeroOne.Stories = 1;

            FiveOneFiveZero.Construct();
            TwoOneFour.Construct();
            OneZeroOne.Construct();

            FiveOneFiveZero.Purchase("Sammy Hagar");
            TwoOneFour.Purchase("Gordon Gecko");
            OneZeroOne.Purchase("Brian Johnson");
        }
    }
}
