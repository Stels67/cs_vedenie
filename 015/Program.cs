// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет (Вывести: NO).
int a, c;
System.Console.WriteLine("Ввудите число -");
a=Convert.ToInt32(Console.ReadLine());
if(a>99)
{
    c=Math.Abs(a)/100;
    System.Console.WriteLine(c);
}
else
{
    System.Console.WriteLine("No");
}