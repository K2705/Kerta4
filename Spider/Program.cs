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
            Console.WriteLine(crevice.Poke());
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
            crevice.addSpider(Shelob);
            crevice.addSpider(Charlotte);
            crevice.addSpider(new Spider("black widow spider", "deadly neurotoxin", 3));
            crevice.addSpider(new Spider("giant spider", "2d4 poison damage", 1000000));
            crevice.addSpider(new Spider("giant cave spider", "paralytic venom", 10000000));
            crevice.addSpider(new Spider());
            Console.WriteLine(crevice.Poke());
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
            Console.WriteLine(crevice.Poke());
            Console.WriteLine("Press any key to continue . . .");
            Console.ReadKey();
            Console.WriteLine(crevice.Poke());
        }
    }
}
