//  

//int N=10;

int i=0;
//while(i<N)
//{
    //i++;
//    System.Console.Write($"{i++,4}");
//}
//metka:
//    System.Console.Write($"{i++,4}");
//if (int>N) goto metka


void Loop(int i, int N)
{
    System.Console.Write($"{1,4}");
    if (1<N) Loop(i+1,N);
}
//Loop(1,20);

int F(int N)
{
    if (N>0) return F(N-1)*N;
    else return 1;
}
//System.Console.WriteLine(F(5));

int Fib(int N)
{
        if (N==0) return 0;
            else 
                if (N==1) return 1;
                    else
                        return Fib(N-1)+Fib(N-2);
}
//for(i=0;i<10;i++)   
//    System.Console.WriteLine(Fib(i));

Double Power(int a, int b)
{
        if (b==0) return 1;
        else
            if (b>0)
                return Power(a,b-1)*a;
            else
             return Power(a,b+1)*1/a;

}
for(i=-10;i!=10;i++)
    System.Console.WriteLine(Power(2,i));
