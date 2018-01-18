using System;

namespace Spider
{
    class Crevice
    {
        private int maxSpiders;
        private Spider[] spiders;

        public Crevice(int max)
        {
            this.maxSpiders = max;
            this.spiders = new Spider[maxSpiders];
        }

        public Spider getSpider()
        {
            if (spiders.Length == 0)
            {
                throw new OutOfSpidersException("This crevice has zero spiders inside it!");
            }
            else
            {
                return spiders[new Random().Next(0, spiders.Length)];
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
