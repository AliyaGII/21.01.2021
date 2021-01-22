using System;

namespace _21._02._2021
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задание № 1.1

            Console.WriteLine("Enter a first number");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number");
            int B = Convert.ToInt32(Console.ReadLine());

            /* int max = A > B ? B = A : A = B;*/

            if (A == B)
            {
                A = 0;
                B = 0;
            }
            else if (A > B)
            {
                B = A;
            }
            else
            {
                A = B;
            }

            Console.WriteLine("A = " + A.ToString() + ", B = " + B.ToString());



            // Задание № 1.2

            Console.WriteLine("Enter a first number ");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a second number ");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose math sign (+, -, *, /) ");
            char sign = Convert.ToChar(Console.ReadLine());

            switch (sign)
            {
                case '+':
                    Console.WriteLine(operand1 + operand2);
                    break;
                case '-':
                    Console.WriteLine(operand1 - operand2);
                    break;
                case '*':
                    Console.WriteLine(operand1 * operand2);
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Error");
                    }
                    else
                    {
                        Console.WriteLine(operand1 / operand2);
                    }
                    break;
            }



                    // Задание № 1.3
             Console.WriteLine("Enter a number");
             int number = Convert.ToInt32(Console.ReadLine());
             string Incorrect = "Incorrect number";

            if (number < 0 && number > 100)
                Console.Write(Incorrect);
            else if (number <= 14)
                Console.WriteLine("[0 - 14]");
            else if (number <= 35)
                Console.WriteLine("[15 - 35]");
            else if (number <= 50)
                Console.WriteLine("[36 - 50]");
            else if (number <= 100)
                Console.WriteLine("[50 - 100]");

            Console.ReadKey();



            // Задание № 2.1
            Console.Write("Enter total price: ");
            double.TryParse(Console.ReadLine(), out var Amount);
            var discount = 0.0;
            if (Amount > 1000)
            {
                discount = 0.05;
            }
            else if (Amount > 500)
            {
                discount = 0.03;
            }
            Console.WriteLine($"payment amount: {Amount - (Amount * discount)}");


            // Задание № 2.2

            Console.WriteLine("Введите число А");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число В");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число С");
            var num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число D");
            var num4 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 && num2 == num3 && num3 == num4)
            {
                Console.WriteLine("Числа расположены по возрастанию" + (num1 * num2 * num3 * num4));
            }
            else if (num1 < num2 && num2 < num3 && num3 < num4)
            {
                var min = Math.Min(Math.Min(num1, num2), Math.Min(num3, num4));
                Console.WriteLine(min);
            }
            else  
            {
                Console.WriteLine("Числа расположены по возрастанию");
            }




            // Задание № 2.3

            Console.WriteLine("Введите число А");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число В");
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число С");
            var c = Convert.ToInt32(Console.ReadLine());

            a = a + b + c;
            b = b + c;

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
        }
        }
    }

