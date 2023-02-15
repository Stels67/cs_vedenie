// Возведите число А в натуральную степень B используя цикл

int a,b;
System.Console.WriteLine("Введите число а");
a=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите в какую степепень вы хотите возвести число=");
b=Convert.ToInt32(Console.ReadLine());
for (int i=0; i<1; i++)
{
    int c;
    c=(int)Math.Pow(a,b);
    System.Console.WriteLine(c);
}
