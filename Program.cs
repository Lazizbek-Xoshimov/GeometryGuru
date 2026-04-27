Console.Write("Birinchi sonni kiriting: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Ikkinchi sonni kiriting (0 ga teng bo'lmagan): ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Bu sonlar ustida quyidagi 4 ta amal bajarildi:");

Console.WriteLine(a + " + " + b + " = " + (a + b));
Console.WriteLine(a + " * " + b + " = " + (a * b));
Console.WriteLine(a + " - " + b + " = " + (a - b));
Console.WriteLine(a + " / " + b + " = " + (Convert.ToDecimal(a) / Convert.ToDecimal(b)));