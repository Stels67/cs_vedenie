﻿// 34.Определить количество цифр в числе. Сделать подпрограмму.

int CounterDigits(int n)
{
    if (n==0) return 1;

    int counter=0;
    while (n!=0)
    {
        counter++;
        n/=10;
    }
    return counter;
}
int N=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(CounterDigits(N));
