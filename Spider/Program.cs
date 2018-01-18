using System;

namespace Spider
{
    class Program
    {
        static void Main(string[] args)
        {
            Spider Charlotte = new Spider();
            Spider Shelob = new Spider("brown recluse spider", "deadly necrotoxin", 3);
            Console.WriteLine("Current spiders: {0} and {1}", Charlotte.name, Shelob.name);

            Charlotte.TearLeg();
            Charlotte.TearLeg();

            Console.WriteLine(Charlotte.Bite());
            Console.WriteLine(Shelob.Bite());
            Console.WriteLine("{0} has {1} legs remaining and {2} has {3}.", Charlotte.name, Charlotte.CountLegs(), Shelob.name, Shelob.CountLegs());

            Crevice crevice = new Crevice(5);
            Console.WriteLine("Spider: {0}.", crevice.getSpider().name);
        }
    }
}
