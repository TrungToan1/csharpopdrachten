using System;

namespace ClassOpdracht1
{
    //Schrijf met commentaar(//dit is commentaar) in deze file de naam bij elk onderdeel 
    internal class ClassStructureExercise //class
    {
        private readonly string accountName; //string variable

        internal ClassStructureExercise(string accountName) //Constructor
        {
            this.accountName = accountName;  //Variable
        }

        internal void ShowGreetingInConsole() //Function
        {
            string greeting = "hello"; //Variable
            Console.WriteLine(greeting + " " + accountName); //Argument
        }

        internal void Show1To10() //Function
        {
            for (int i = 0; i < 10; i++) //Loop
            {
                Console.WriteLine(i.ToString()); //Argument
            }
        }

        internal double DistBetweenPoints(int x1, int y1, int x2, int y2) //Variable
        {

            int dx = x2 - x1; //Argument
            int dy = y2 - y1; //Argument

            double lengthSquared = (dx * dx) + (dy * dy); //Argument

            double length = Math.Sqrt(lengthSquared); //Argument
            return length; //Argument

        }
        internal int MultiplyToPower2(int value) //Constructor
        {
            int result = value * value; //Variable
            return result; //Argument
        }


        static void Main(string[] args) //Constructor
        {
            Console.WriteLine("Hello, World!"); //Argument

        }
    }
}