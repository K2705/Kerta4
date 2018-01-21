using System;

namespace CD
{
    class Program
    {
        static void Main(string[] args)
        {
            CompactDisk CD = new CompactDisk("Unholy Savior", "Battle Beast", "Heavy Metal", "14.99€");
            Console.Write(CD);
        }
    }
}
