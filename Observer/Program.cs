using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer pattern");
           
            var newsSite = new News();

            for (int i = 0; i < 5; i++)
            {
                newsSite.Attach(new Reader(newsSite));
            }

            newsSite.UpdateNews("Amazing news!");


        }
    }
}
