// С клавиатуры вводятся три числа. Найти максимальное из трех чисел

int a,b,c, max1, max2, max3;
System.Console.Write("Введите a:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите c:");
c=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    max1=a;
}
else
{
    max1=b;
}
if (max1>c)
{
    max2=max1;
}
else 
{
    max2=c;
}

Console.WriteLine ($"Максимальное число равно {max2}");