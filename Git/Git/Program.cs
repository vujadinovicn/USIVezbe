using System;
using System.IO;

namespace Git
{
    class Program
    {

        static int addition(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            while (true) {
                var line = Console.ReadLine();
                if (line == "exit" || line == "kraj") 
                    break;
                string[] expression = line.Split();
                if (expression.Length != 3) {
                    Console.WriteLine("Kraj");
                    break;
                }
                int operand1 = Int32.Parse(expression[0]);
                int operand2 = Int32.Parse(expression[2]);
                int result = addition(operand1, operand2);
                Console.WriteLine(result);
            }
        }
    }
}
