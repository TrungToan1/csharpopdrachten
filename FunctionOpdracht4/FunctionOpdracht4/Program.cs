using System;

namespace FunctionOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program= new Program();


            int result = program.AddNumbers(2, 6, 18);

            Console.WriteLine("should be 26?");
            Console.WriteLine(result);
        }


        //1) maak hier een function AddNumbers die 3 argumenten heeft
        int x = 2;
        int y = 6;
        int z = 10;

        public int AddNumbers(int x, int y, int z)
        {
            int result = x + y + z;
            return result;
        }
        //2) de function telt de 3 argumenten bij elkaar op en geeft dat als resultaat terug

    }
}