// 045 Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] a;
a=new int[50];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(100,200);

for(int i=0;i<a.Length;i++)
    
    System.Console.Write($"{a[i]} ");
    
System.Console.WriteLine();

int g=a[0];
for(int i=1;i<a.Length;i++)
    if(a[i]%2==0)
    System.Console.WriteLine($"Четное {a[i]} число ");
else
    System.Console.WriteLine($"неЧетное {a[i]} число ");


