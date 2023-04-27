// Программа принимающая на вход 5ти значное число и проверяет его явл ли оно полиндромом
Console.Clear();
Console.WriteLine("                      ЗАДАЧА ПРОВЕРЯЕТ ВВЕДЕННОЕ 5ТИ ЗНАЧНОЕ ЧИСЛО НА ПОЛИНДРОМНОСТЬ");
Console.WriteLine("Введите 5ти значное число: ");
int FIVE = int.Parse(Console.ReadLine());

if (FIVE>9999 && FIVE<99999)
{
int num1 = FIVE/10000;
int num2 = (FIVE/1000)%10;
int num4 = (FIVE%100)/10;
int num5 = FIVE%10;
    if (num1 == num5 && num2 == num4)
    {
        Console.WriteLine($" Число {FIVE} является полиндромом");
    }
    else 
    {
        Console.WriteLine($" Число {FIVE} НЕ является полиндромом");
    }
}
else
{
    Console.WriteLine($" Число {FIVE} не удовлетваряет требованиям");
}

// =================================================================================================

// Программа принимающая на вход две точки с координатами и затем определяет расстояние между ними в пространстве

Console.WriteLine("                      ЗАДАЧА НА ВВОД КООРДИНАТЫ ДВУХ ТОЧЕК НА ВЫХОД РАССТОЯНИЕ МЕЖДУ ТОЧКАМИ");
Console.Write("Введите координату Х1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double Z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z1: ");
double Z2 = Convert.ToDouble(Console.ReadLine());
double R = Math.Sqrt(((X2-X1)*(X2-X1)+(Y2-Y1)*(Y2-Y1)+(Z2-Z1)*(Z2-Z1)));
Console.WriteLine($"Расстояние между точками равно: {R}");

// =================================================================================================

// Программа на вход число N на выход кубы числел от 1 до N

Console.WriteLine("                      ЗАДАЧА НА ВВОД ЧИСЛО N НА ВЫХОД КУБЫ ЧИСЕЛ ОТ 1 ДО N");
Console.WriteLine("Введите число N");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i<=N; i++)
{
    int KUB = i*i*i;
    Console.Write($" {KUB}");
}