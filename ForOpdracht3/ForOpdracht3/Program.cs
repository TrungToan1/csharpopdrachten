﻿using System;

namespace ForOpdracht3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Enemies[] enemies = new Enemies[]
            {
                new Enemies() { defeated = true, name = "isdead" },
                new Enemies() { defeated = false, name = "stillalive" }
            };

            for (int i = 0; i < enemies.Length; i++)
            {
                //als een enemy defeated = true heeft, doe dan een Console.WriteLine waar je de name laat zien en dat deze defeated is
                if (enemies[i].defeated == true) 
                {
                    Console.WriteLine(enemies[i].name);
                }
                else if (enemies[i].defeated == false)
                {
                    Console.WriteLine(enemies[i].name);
                }
            }
            
        }
    }
}