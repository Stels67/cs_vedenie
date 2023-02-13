// Дано число. Проверить кратно ли оно 7 и 23
int a, b, c;

System.Console.WriteLine("Введите число -");
a=Convert.ToInt32(Console.ReadLine());
b=7;
c=23;
if(a%b==0 && a%c==0)
{
    System.Console.WriteLine($"Число {a} кратно 7 и 23 кратность на 7 =" + a/b + ", кратность на 23 =" + a/c);
}
else
{
    System.Console.WriteLine("число не кратно 7 и 23");
}