using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider
{
    /// <summary>
    /// It is a spider!
    /// </summary>
    class Spider
    {
        public String name { get; }
        private String venom;
        private int intactLegs;
        public int size;

        public Spider(String name, String venom, int size)
        {
            this.name = name;
            this.venom = venom;
            this.intactLegs = 8;
            this.size = size;
        }

        public Spider() : this("default spider", "nothing", 1)
        {
        }

        public String Bite()
        {
            return "The " + name + " bites you, injecting you with " + venom + "!";
        }
        /// <summary>
        /// Pull a leg off the spider (if legs remain)
        /// </summary>
        public void TearLeg()
        {
            if (intactLegs <= 0)
            {
                Console.WriteLine("The spider has no legs left.");
            }
            else
            {
                intactLegs--;
                Console.WriteLine("You pull a leg off the {0}. You monster. {1} legs remain.", name, intactLegs);
            }
        }

        public int CountLegs()
        {
            return intactLegs;
        }

        
        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false; //It's not even a spider.
            Spider otherSpider = (Spider)obj;
            if (otherSpider.name != this.name
                || otherSpider.venom != this.venom
                || otherSpider.intactLegs != this.intactLegs
                || otherSpider.size != this.size)
                return false;
            
            return true;
        }
    }
}
