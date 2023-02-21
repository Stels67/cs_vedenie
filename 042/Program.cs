int[] a=new int[12];
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(-9,10);

for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]}");

System.Console.WriteLine();

int sp=0;
for(int i=0; i<a.Length;i++)
    if (a[i]>0)
        sp=sp+a[i];

int sn=0;
for(int i=0;1<a.Length;i++)
    if (a[i]>0)
        sp=sp+a[i];
System.Console.WriteLine($"Sum of positive {sp}");
System.Console.WriteLine($"Sum of negativ {sn}");
