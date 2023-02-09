// Вывести на экран последнюю цифру целого числа введенного с клавиатуры. 

int a;
int c;
System.Console.WriteLine("введите число -");
a=Convert.ToInt32(Console.ReadLine());
c = Math.Abs(a)%10;
System.Console.WriteLine(c);
