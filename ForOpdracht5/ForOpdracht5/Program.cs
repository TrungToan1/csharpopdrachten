using System;

namespace ForOpdracht5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int[] nummers = new int[] { 0,1,2,3,4,5,6,7,8,9};

            //zorg ervoor dat alleen 3 tot en met 7 op de console komen,
            //doe dit door de start ( i= 0) en tot (nummers.length) van de for aan te passen
            for (int i = 0; i < nummers.Length; i++)
            {
                if (nummers[i] >= 3 && nummers[i] <= 7)
                {
                    Console.WriteLine(nummers[i]);
                }
              
            }

            
        }
    }
}