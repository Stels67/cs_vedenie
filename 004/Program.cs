// По заданному с клавиатуры номеру дня недели вывести его название


System.Console.Write("Введите день недели:");
int n;
n=Convert.ToInt32(Console.ReadLine());
 
if (n==1)
{
    System.Console.WriteLine($"Monday является {n} днем недели");
}
if (n==2)
{
    System.Console.WriteLine($"Tuesday является {n} днем недели");
}
if (n==3)
{
    System.Console.WriteLine($"Wednesday является {n} днем недели");
}
if (n==4)
{
    System.Console.WriteLine($"Thursday является {n} днем недели");
}
if (n==5)
{
    System.Console.WriteLine($"Friday является {n} днем недели");
}
if (n==6)
{
    System.Console.WriteLine($"Saturday является {n} днем недели");
}
if (n==7)
{
    System.Console.WriteLine($"Sunday является {n} днем недели");
}
if (n>7)
{
    System.Console.WriteLine($" {n} не является днем недели");
}
