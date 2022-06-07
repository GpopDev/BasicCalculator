using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.Write("Insert first number: ");
                double number1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Insert second number: ");
                double number2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("[+] What u wanna do");
                Console.WriteLine("[+] M to multiply, S suma, R restar, D division");
                string no = Console.ReadLine();
                string response = no.ToLower();

                switch (response)
                {
                    case "s":
                        double response_s = number1 + number2;
                        Console.WriteLine("[+] The result is: " + response_s);
                        Console.ReadKey();
                        break;

                    case "m":
                        double response_m = number1 * number2;
                        Console.WriteLine("[+] The result is: " + response_m);
                        Console.ReadKey();
                        break;

                    case "r":
                        double response_r = number1 - number2;
                        Console.ReadKey();
                        break;

                    case "d":
                        double response_d = number1 / number2;
                        Console.WriteLine("[+] The result is: " + response_d);
                        Console.ReadKey();
                        break;
                }
        }
    }
}
