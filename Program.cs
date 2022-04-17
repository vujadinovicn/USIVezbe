using System;

namespace Practice
{
    class Program
    {

        public static void first_method() {
            Console.WriteLine("First method!");
        }
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Unesite izraz: ");
                string s = Console.ReadLine();
                if (s == "exit") {
                    break;
                }
            }
        }
    }
}
