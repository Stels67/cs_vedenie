//31Вывести на экран кубы чисел от 1 до N

Random random;
random=new Random();
int c;

System.Console.WriteLine("Ввыедите какое колличество случайных цифр возведенных в куб вы хотите увидеть =");
c=Convert.ToInt32(Console.ReadLine());
for (int i=0; i<c; i++)

{
    int a=random.Next(1,100);
    int b=(int)Math.Pow(a,3);
    System.Console.WriteLine($"{a}, {b}"); 
}
