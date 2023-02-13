// По двум заданным числам проверять является ли одно квадратом другого.
int a,b;
System.Console.WriteLine("введите число а=");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b=");
b=Convert.ToInt32(Console.ReadLine());
if (a*a==b)
    System.Console.WriteLine("b является квадратом a");
else
    System.Console.WriteLine("а не кратно b");
if (b*b==a)
    System.Console.WriteLine("a является квадратом b");
else
    System.Console.WriteLine("b не кратно а");
    