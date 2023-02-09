// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

int a,b,c,max1;
System.Console.WriteLine("введите число -");
a=Convert.ToInt32(Console.ReadLine());
if((a>10)&&(a<101))
{
    b=a%10;
    c=a/10%10;
    if (b>c)
        {
            max1=b;
        }
    else
        {
            max1=c;
        }
        System.Console.WriteLine("Наибольшее число -"+ max1);
}

