Console.WriteLine("Qaysi amal ustida ishlamoqchisiz?");
Console.WriteLine("- Qo'shish (+)");
Console.WriteLine("- Ko'paytirish (*)");
Console.WriteLine("- Ayirish (-)");
Console.WriteLine("- Bo'lish (/)");
Console.WriteLine("- Qoldiqni hisoblash (%)");

Console.Write("Kerakli arifmetik operatorni kiriting: ");
string str = Console.ReadLine();
char departmentCharacter = Convert.ToChar(str);

Console.Write("Birinchi sonni kiriting: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Ikkinchi sonni kiriting: ");
int b = Convert.ToInt32(Console.ReadLine());

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
                Console.WriteLine("Ikkinchi son 0 bo'lishi mumkin emas!");
            break;
        }
    case '%':
        if(b != 0)
                Console.WriteLine(a + " % " + b + " = " + (a % b));
            else
                Console.WriteLine("Ikkinchi son 0 bo'lishi mumkin emas!");
            break;
    default:
        Console.WriteLine("Boshqa belgi kiritdingiz!\nDasturni qaytadan ishga tushiring.");
        break;
}