using System;

namespace Spider
{
    class Crevice
    {
        private int maxSpiders;
        private int spiderCount;
        private Spider[] spiders;

        public Crevice(int max)
        {
            this.maxSpiders = max;
            this.spiderCount = 0;
            this.spiders = new Spider[maxSpiders];
        }

        /// <summary>
        /// Get a random spider from the crevice
        /// Throws OutOfSpidersException if the crevice has no spiders
        /// </summary>
        /// <returns>a Spider</returns>
        public Spider getSpider()
        {
            if (spiderCount == 0)
            {
                throw new OutOfSpidersException("This crevice has zero spiders inside it!");
            }
            else
            {
                return spiders[new Random().Next(0, spiderCount)];
            }
        }

        /// <summary>
        /// Add a new spider into the crevice
        /// </summary>
        /// <param name="spider">Spider to be added</param>
        public void addSpider(Spider spider)
        {
            if ( spiderCount < maxSpiders )
            {
                spiders[spiderCount] = spider;
                spiderCount++;
                //Spider added successfully
            }
            else
            {
                Console.WriteLine("Unable to add spider (crevice full).");
            }
        }
		
		
		public String Poke()
		{
			if (spiderCount > 0)
			{
                Spider spider = getSpider();
                return "You poke at the crevice, and discover a " + spider.name + ". " + spider.Bite();
			}
			else
			{
				return "You poke at the crevice, but it seems to be empty.";
			}
		}
            



    public class OutOfSpidersException : Exception
        {
            public OutOfSpidersException() { }
            public OutOfSpidersException(string message) : base(message) { }
            public OutOfSpidersException(string message, Exception inner) : base(message, inner) { }
            protected OutOfSpidersException(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        }
            
        
    }
}
