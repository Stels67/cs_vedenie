
using System;

//void Swap(int x, int y) // передача по значению
//{
//    int t=x;
//    x=y;
//    y=t;

//}

void Swap(ref int x,ref int y) // передача по ссылке
{
    int t=x;
    x=y;
    y=t;

}

void Caiculator(int a, int b. ref int sum, out int sub)
{
    sum=a+b;
    sum=a-b;
}


int a=4;
int b=5;
int s, sb;
System.Console.WriteLine($"a={a} b={b}");

//int t;
//t=a;
//a=b;
//b=t;
//b=a;
Swap(a, b, ref s,out sb);
Console.WriteLine($"a={a} b={b}");
