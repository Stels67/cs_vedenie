//Программа проверяет пятизначное число на палиндромом. Например 12321

string a;
System.Console.WriteLine("Введите число = ");
a=Console.ReadLine();
char [] b = a.ToCharArray();
Array.Reverse(b);
string c = new string(b);
if(a==c)
{
    System.Console.WriteLine("Палиндром");
}
if(a!=c)
{
    System.Console.WriteLine("не палиндром");
}