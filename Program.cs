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
                Console.WriteLine("6. Sonning tub son ekanligini tekshirish");
                Console.WriteLine("7. Sonning palindrome son ekanligini tekshirish");
                Console.Write("Kerakli bo'limni tanlang: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.Write("Hisoblamoqchi bo'lgan sonni kiriting: ");
                            int number = int.Parse(Console.ReadLine());

                            Console.Write("Hisoblamoqchi bo'lgan sonning darajasini kiriting: ");
                            int degree = int.Parse(Console.ReadLine());

                            double resultToPow = ToPow(number, degree);

                            if (degree == 2)
                            {
                                Console.WriteLine($"{number} ning kvadrati {resultToPow} ga teng.");
                                break;
                            }

                            if (degree == 3)
                            {
                                Console.WriteLine($"{number} ning kubi {resultToPow} ga teng.");
                                break;
                            }

                            Console.WriteLine($"{number} ning {degree} darajasi {resultToPow} ga teng.");
                            break;
                        }
                    case "2":
                        {
                            Console.Clear();
                            Console.Write("[1; n] interval olmoqchi bo'lgan n ni kiriting: ");
                            int n = int.Parse(Console.ReadLine());  

                            SumOfPrimeNumbers(n);

                            break;
                        }
                    case "3":
                        {
                            Console.Clear();
                            Console.WriteLine("Kerakli hisoblash ketma-ketligini kiriting: (a + b =)");
                            string calculate = Console.ReadLine();

                            ArithmeticOperations(calculate);
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
                    case "6":
                        {
                            Console.Clear();
                            Console.Write("Tub son ekanligini tekshirmoqchi bo'lgan sonni kiriting: ");
                            int number = int.Parse(Console.ReadLine());

                            if (IsPrime(number))
                                Console.WriteLine($"{number} - tub son.");
                            else
                                Console.WriteLine($"{number} tub son emas.");
                            break;
                        }
                    case "7":
                        {
                            Console.Clear();
                            Console.Write("Palindrome ekanligini tekshirmoqchi bo'lgan sonni kiriting: ");
                            string numberString = Console.ReadLine();

                            if(IsPalindrome(numberString))
                                Console.WriteLine($"{numberString} palindrome son.");
                            else
                                Console.WriteLine($"{numberString} palindrome son emas.");

                            break;
                        }
                }

                Console.WriteLine("Dasturdan chiqishni xohlaysizmi?");
                Console.Write("(ha/yo'q): ");
                doQuit = Console.ReadLine();
            } while (doQuit.ToLower() == "yo'q");
        }

        static double ToPow(int number, int degree)
        {
            double result = 1;

            for (int i = 0; i < degree; i++)
            {
                result *= number;
            }

            return result;
        }

        static void SumOfPrimeNumbers(int n)
        {
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

        static void ArithmeticOperations(string calculate)
        {
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

        static bool IsPrime(int number)
        {
            int countOfDivisors = 0;

            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                    countOfDivisors ++;
            }

            if (countOfDivisors == 1)
                return true;
            else 
                return false;
        }
        
        static bool IsPalindrome(string numberString)
        {
            for (int i = 0; i < numberString.Length / 2; i++)
            {
                if (numberString[i] != numberString[numberString.Length - 1 - i])
                    return false;
            }

            return true;
        }
    }
}