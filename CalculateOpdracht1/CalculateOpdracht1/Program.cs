<<<<<<< HEAD
﻿using System;

namespace CalculateOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int leeftijdStudent = 16;

            //nu ben je jarig, tel 1 bij je leeftijd op, gebruik de = A+1; constructie (zie video)
            Console.WriteLine("Year 1 Happy birthday!");
            leeftijdStudent = leeftijdStudent + 1;
            Console.WriteLine($"je bent nu {leeftijdStudent}" );



            //nu ben je weer jarig, tel 1 bij je leeftijd op, gebruik de += 1; constructie (zie video)
            Console.WriteLine("Year 2 Happy birthday!");
            leeftijdStudent += 1;
            Console.WriteLine($"je bent nu {leeftijdStudent}");


            //nu ben je weer jarig, tel 1 bij je leeftijd op, gebruik de ++; constructie (zie video)
            Console.WriteLine("Year 3 Happy birthday!");
            leeftijdStudent++;
            Console.WriteLine($"je bent nu {leeftijdStudent}");


            //nu moet er 19 in de console staan als je het programma runt
        }
    }
=======
﻿using System;

namespace CalculateOpdracht1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int leeftijdStudent = 16;

            //nu ben je jarig, tel 1 bij je leeftijd op, gebruik de = A+1; constructie (zie video)
            Console.WriteLine("Year 1 Happy birthday!");
            leeftijdStudent = leeftijdStudent + 1;
            Console.WriteLine($"je bent nu {leeftijdStudent}" );



            //nu ben je weer jarig, tel 1 bij je leeftijd op, gebruik de += 1; constructie (zie video)
            Console.WriteLine("Year 2 Happy birthday!");
            leeftijdStudent += 1;
            Console.WriteLine($"je bent nu {leeftijdStudent}");


            //nu ben je weer jarig, tel 1 bij je leeftijd op, gebruik de ++; constructie (zie video)
            Console.WriteLine("Year 3 Happy birthday!");
            leeftijdStudent++;
            Console.WriteLine($"je bent nu {leeftijdStudent}");


            //nu moet er 19 in de console staan als je het programma runt
        }
    }
>>>>>>> 9fa9e37fd924667d126f28ce655a29ed85d9e58c
}