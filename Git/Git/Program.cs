﻿using System;
using System.IO;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                var line = Console.ReadLine();
                if (line == "exit" or line == "kraj") 
                    break;
            }
        }
    }
}
