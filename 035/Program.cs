// Подсчитать сумму цифр в числе

int a;
System.Console.WriteLine("введите число -");
a=Convert.ToInt32(Console.ReadLine());
if((a>1))
{int s = 0;
            while (a > 0)
            {
 
                s = s + a % 10;
                a = a /10 ;
            }
Console.WriteLine(s);
}
