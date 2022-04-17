using System;

namespace Practice
{
    class Program
    {

        public static string[] parse(string s) {
            string[] tokens = s.Split(" ");
            if (tokens.Length != 3) { throw new Exception("GRESKAAAAA"); }
            return tokens;
        }

        public static int add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("Unesite izraz: ");
                string s = Console.ReadLine();
                if (s == "exit") {
                    break;
                }

                string[] tokens;

                try
                {
                    tokens = parse(s);
                }
                catch (Exception e) {
                    break;
                }
                /*foreach(var token in tokens) {
                    Console.WriteLine(token);
                }*/

                int a = Int32.Parse(tokens[0]);
                int b = Int32.Parse(tokens[2]);

                Console.WriteLine(add(a, b));
            }
        }
    }
}
