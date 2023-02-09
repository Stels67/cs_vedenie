//С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.


int a, b, c;

System.Console.WriteLine("Введите число -");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число -");
b=Convert.ToInt32(Console.ReadLine());
c=a/b;
if(c == Math.Truncate(c))
{
    System.Console.WriteLine("Кратность равна - "+c);
}
else
{
    System.Console.WriteLine("Остаток - "+a%b);
}

//System.Console.WriteLine("Кратность равна - "+a/b);
//System.Console.WriteLine("Остаток - "+a%b);
