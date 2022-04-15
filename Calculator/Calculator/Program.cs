using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a number and press enter");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a number and press enter");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chose an option from the following list");
            Console.WriteLine("\t A-Add");
            Console.WriteLine("\t S-Subtract");
            Console.WriteLine("\t D-Divide");
            Console.WriteLine("\t M-Multiply");
            for (int i = 0; i < 4; i++)
            {
                switch (Console.ReadLine())
                {
                    case "A":
                        Console.WriteLine("Result= " + (num1 + num2));
                        break;
                    case "S":
                        Console.WriteLine("Result= " + (num1 - num2));
                        break;
                    case "D":
                        Console.WriteLine("Result= " + (num1 / num2));
                        break;
                    case "M":
                        Console.WriteLine("Result= " + (num1 * num2));
                        break;
                }
            }
            Console.ReadKey();

        }
    }
}
