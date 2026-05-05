using System.Drawing;

Console.WriteLine("1. Sonning darajasini topish");
Console.WriteLine("2. [1; n] intervalda tub sonlar va ularning yig'indisini hisoblash");
Console.WriteLine("3. Arifmetik amallarni hisoblash");
Console.Write("Kerakli bo'limni tanlang: ");

string option = Console.ReadLine();

switch (option)
{
    case "1":
        {
            break;
        }
    case "2":
        {
            break;
        }
    case "3":
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
                    Console.WriteLine(a + " + " + b + " = " + (a + b));
                    break;
                case '*':
                    Console.WriteLine(a + " * " + b + " = " + (a * b));
                    break;
                case '-':
                    Console.WriteLine(a + " - " + b + " = " + (a - b));
                    break;
                case '/':
                    {
                        if(b != 0)
                            Console.WriteLine(a + " / " + b + " = " + (a / b));
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
                            Console.WriteLine(a + " % " + b + " = " + (a % b));
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
            break;
        }
}