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
                if (line == "exit" || line == "kraj") 
                    break;
                string[] expression = line.Split();
                if (expression.Length == 3) {
                    Console.WriteLine("Tacno");
                }
            }
        }
    }
}
