﻿using RPG.ItemSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            GUI gui = new GUI();
            gui.StartStory();
            Console.WriteLine("hello world");
            Console.ReadLine();
        }
    }
}
