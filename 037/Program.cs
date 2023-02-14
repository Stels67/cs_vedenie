// Показать кубы чисел, заканчивающихся на четную цифру

bool Test(int n)
{
    return n%2==0;
    //if (n%2=00)
    //    return true;
    //else
    //    return false;
}
Random random;
random=new Random();
int c;
c = 3;
for (int i=0; i<10; i++)
{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    if (Test(a));
    System.Console.WriteLine($"{a}, {b}");
}
//Random random1=new Random();
//Random random2=new Random();
//System.Console.WriteLine(random.Next(1,100));
//System.Console.WriteLine(random1.Next(1,100));
//System.Console.WriteLine(random2.Next(1,100));