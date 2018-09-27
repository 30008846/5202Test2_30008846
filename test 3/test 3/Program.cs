using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_3
{
    class Bird
    {
        private string Name { get; set; }
        private string Species { get; set; }
        private string Sex { get; set; }
        private string Weight { get; set; }
        private string BandNo { get; set; }

        public Bird(string name, string species, string sex, string weight, string bandNo)
        {
            Name = name;
            Species = species;
            Sex = sex;
            Weight = weight;
            BandNo = bandNo;
        }

        public void DisplayBird()
        {
            Console.WriteLine("*****************************************");
            Console.WriteLine("BIRD OF PREY DATA OUTPUT");

            Console.WriteLine("Bird Name  {0}.", Name);
            Console.WriteLine("Species : {0}.", Species);
            Console.WriteLine("Sex : {0}.", Sex);
            Console.WriteLine("Weight : {0}.", Weight);
            Console.WriteLine("BandNumber {0}.", BandNo);
            Console.WriteLine("*****************************************");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bird object created and default data loaded...");
            Console.WriteLine();
            Console.WriteLine("PLEASE UPDATE BIRD DATA");
            Console.WriteLine();
            Console.Write("Enter Bird name :");
            string Name = Console.ReadLine();

            Console.Write("Enter Species :");
            string Species = Console.ReadLine();

            Console.Write("Enter Sex of Bird :");
            string Sex = Console.ReadLine();

            Console.Write("Enter Weight of a Bird :");
            string Weight = Console.ReadLine();

            Console.Write("Enter a Band number of Bird :");
            string BandNo = Console.ReadLine();

            Bird birdObj = new Bird(Name, Species, Sex, Weight, BandNo);
            birdObj.DisplayBird();

            Console.ReadLine();


        }
    }
}
