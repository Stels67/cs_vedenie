//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

    
int[] a=new int[123];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,1010);
for(int i=0;i<a.Length;i++)
   System.Console.Write($"{a[i]} ");

int g=a[0];
int count=0;
for(int i=0;i<a.Length;i++)
    if((a[i]>10) && (a[i]<100)) count++;
    {
        System.Console.WriteLine($"Элементов из диапозона от 10 до 99 = {count}");
    }