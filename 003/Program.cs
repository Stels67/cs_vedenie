// С клавиатуры вводятся два числа a и b. Найти максимальное из них. (блок-схема)
int a,b;

int max;
System.Console.Write("Введите a:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    max=a;
}
else
{
    max=b;
}
System.Console.WriteLine($"max={max}");