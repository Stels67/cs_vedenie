//  

//int N=10;

//int i=0;
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
Loop(1,20);
