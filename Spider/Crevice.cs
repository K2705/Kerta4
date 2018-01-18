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
