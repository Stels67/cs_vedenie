// вводится число, проверить есть ли в этом числе цифра 0
int N = 12034;
bool flag=false;
while(N!=0)
{
    int digit=N%10;
    if (digit==0)
        flag=true;
    N/=10;
}
if (flag)
    System.Console.WriteLine("В числе есть 0");
else   
    System.Console.WriteLine("В числе нет 0");
