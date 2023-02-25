// 48 Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10. 
//Создайте массив, который является произведением пар чисел в одномерном массиве a. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д.
//а) вариант когда в массиве четное кол-во элементов
//б) * вариант когда в массиве и четное и не четное кол-во элементов

int[] a=new int[10]; 
Random random=new Random();
for(int i=0;i<a.Length;i++)
    a[i]=random.Next(0,11);
for(int i=0;i<a.Length;i++)
    System.Console.Write($"{a[i]} \n");

int[] b=new int[10]; // ответ б вариант когда в массиве и четное и не четное кол-во элементов
Random random2=new Random();
for(int i=0;i<b.Length;i++)
    b[i]=random.Next(0,11);
for(int i=0;i<b.Length;i++)
    System.Console.Write($"четное кол-во элементов {a[i]*b[i]} "+"\n");

int[] c=new int[9]; // ответ а вариант когда в массиве четное кол-во элементов
Random random3=new Random();
for(int i=0;i<c.Length;i++)
    c[i]=random.Next(0,11);
for(int i=0;i<c.Length;i++)
    System.Console.WriteLine($"неЧетное кол-во элементов {a[i]*c[i]} ");

