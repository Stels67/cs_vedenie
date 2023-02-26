// arrayReverse

//int [] a=new int[5] {3, 2, 7, 1,9};

//int t;
//for(int i=0;i<a.Length/2;i++)
//{
//    t=a[i];
///    a[i]=a[a.Length-i-1];
//    a[a.Length-i-1]=t;
//}

//for(int i=0;i<a.Length;i++)
//    System.Console.Write($"{a[i]} ");


    // Инверсия массива
// 3 2 7 1 9
//9 1 7 2 3

int[] a= {3, 2, 7, 1, 9,3,8, 7};

PrintArray(a);
ReverseArray(a);
System.Console.WriteLine();
PrintArray(a);

void PrintArray(int[] a)
{
    for(int i=0;i<a.Length;i++)
        System.Console.Write($"{a[i]} ");
}

void Swap(ref int a, ref int b)
{
    int t=a;
    a=b;
    b=t;
}
void ReverseArray(int[] a)
{
    for(int i=0;i<a.Length/2;i++)
    {
    Swap(ref a[i],ref a[a.Length-i-1]);
    }

}
