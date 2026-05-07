using System;

namespace GeometryGuru
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string doQuit = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine("1. Sonning darajasini topish");
                Console.WriteLine("2. [1; n] intervalda tub sonlar va ularning yig'indisini hisoblash");
                Console.WriteLine("3. Arifmetik amallarni hisoblash");
                Console.WriteLine("4. 3 ta sondan katta sonni hisoblash");
                Console.WriteLine("5. Factorial hisoblash");
                Console.Write("Kerakli bo'limni tanlang: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        {
                            Console.Clear();
                            ToPow();
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            SumOfPrimeNumbers();
                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            ArithmeticOperations();
                            break;
                        }
                    case "4":
                        {
                            Console.Clear();
                            Console.WriteLine("Taqqoslashingiz kerak bo'ladigan sonlarni kiriting.");
                            
                            Console.Write("Birinchi son: ");
                            int firstNumber = int.Parse(Console.ReadLine());

                            Console.Write("Ikkinchi son: ");
                            int secondNumber = int.Parse(Console.ReadLine());

                            Console.Write("Uchinchi son: ");
                            int thirdNumber = int.Parse(Console.ReadLine());

                            int largerNumber = GetMaxValue(firstNumber, secondNumber, thirdNumber);

                            if (largerNumber == firstNumber)
                                Console.WriteLine($"Eng kattasi birinchi son - {largerNumber}");
                            else if (largerNumber == secondNumber)
                                Console.WriteLine($"Eng kattasi ikkinchi son - {largerNumber}");
                            else
                                Console.WriteLine($"Eng kattasi uchinchi son - {largerNumber}");

                            break;
                        }
                    case "5":
                        {
                            Console.Clear();
                            Console.Write("Factorial hisoblanishi kerak bo'lgan sonni kiriting: ");
                            int number = int.Parse(Console.ReadLine());

                            int factorialOfNumber = Factorial(number);

                            Console.WriteLine($"{number}! = {factorialOfNumber}");

                            break;
                        }
                }

                Console.WriteLine("Dasturdan chiqishni xohlaysizmi?");
                Console.Write("(ha/yo'q): ");
                doQuit = Console.ReadLine();
            } while (doQuit.ToLower() == "yo'q");
        }

        static void ToPow()
        {
            Console.Write("Hisoblamoqchi bo'lgan sonni kiriting: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Hisoblamoqchi bo'lgan sonning darajasini kiriting: ");
            int degree = int.Parse(Console.ReadLine());

            double result = 1;

            for (int i = 0; i < degree; i++)
            {
                result *= number;
            }

            if (degree == 2)
            {
                Console.WriteLine($"{number} ning kvadrati {result} ga teng.");
            }

            if (degree == 3)
            {
                Console.WriteLine($"{number} ning kubi {result} ga teng.");
            }

            Console.WriteLine($"{number} ning {degree} darajasi {result} ga teng.");
        }

        static void SumOfPrimeNumbers()
        {
            Console.Write("[1; n] interval olmoqchi bo'lgan n ni kiriting: ");
            int n = int.Parse(Console.ReadLine());

            int summa = 0;

            Console.Write($"[1; {n}] intervalidagi tub sonlar: ");
            for (int i = 1; i <= n; i++)
            {
                int divisorCount = 0;
                for (int j = 1; j <= i; j ++)
                {
                    if (i % j == 0)
                        divisorCount ++;
                }

                if (divisorCount == 2)
                {
                    Console.Write(i + " ");
                    summa += i;
                }
            }

            Console.WriteLine($"\n[1; {n}] intervalidagi tub sonlar yig'indisi {summa} ga teng.");
        }

        static void ArithmeticOperations()
        {
            Console.WriteLine("Kerakli hisoblash ketma-ketligini kiriting: (a + b =)");
            string calculate = Console.ReadLine();

            string[] operators = calculate.Trim().Split();

            char departmentCharacter = Convert.ToChar(operators[1]);
            int a = Convert.ToInt32(operators[0]);
            int b = Convert.ToInt32(operators[2]);

            Console.Clear();
            switch (departmentCharacter)
            {
                case '+':
                    Console.WriteLine(a + " + " + b + " = " + AddTwoNumbers(a, b));
                    break;
                case '*':
                    Console.WriteLine(a + " * " + b + " = " + MultiplicationTwoNumbers(a, b));
                    break;
                case '-':
                    Console.WriteLine(a + " - " + b + " = " + SubtractTwoNumbers(a , b));
                    break;
                case '/':
                    {
                        if(b != 0)
                            Console.WriteLine(a + " / " + b + " = " + DivisionTwoNumbers(a, b));
                        else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ikkinchi son 0 bo'lishi mumkin emas!");
                                Console.ResetColor();
                            }
                        break;
                    }
                case '%':
                    {
                        if(b != 0)
                            Console.WriteLine(a + " % " + b + " = " + ResidualTwoNumbers(a, b));
                        else
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.WriteLine("Ikkinchi son 0 bo'lishi mumkin emas!");
                                Console.ResetColor();
                            }
                        break;   
                    }
                default:
                    Console.WriteLine("Boshqa belgi kiritdingiz!\nDasturni qaytadan ishga tushiring.");
                    break;
            }
        }

        static int AddTwoNumbers(int a, int b) => a + b;

        static int MultiplicationTwoNumbers(int a, int b) => a * b;

        static int SubtractTwoNumbers(int a, int b) => a - b;

        static int DivisionTwoNumbers(int a, int b) => a / b;

        static int ResidualTwoNumbers(int a, int b) => a % b;

        static int GetMaxValue(int firstNumber, int secondNumber, int thirdNumber)
        {
            if (firstNumber < secondNumber)
            {
                if (secondNumber < thirdNumber)
                    return thirdNumber;
                else
                    return secondNumber;
            }
            else
            {
                if (firstNumber < thirdNumber)
                    return thirdNumber;
                else
                    return firstNumber;
            }
        }

        static int Factorial(int number)
        {
            int numberOfFactorial = 1;

            for (int i = 2; i <= number; i++)
            {
                numberOfFactorial *= i;
            }

            return numberOfFactorial;
        }
    }
}