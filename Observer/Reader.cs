using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Reader : Observer
    {
        private News newsSite;
        
        public Reader(News newsSite)
        {
            this.newsSite = newsSite;
        }

        public void Update()
        {
            Console.WriteLine($"Incoming news!: {newsSite.GetNews()}{Environment.NewLine}");
        }
    }
}
