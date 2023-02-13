// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x,y;
System.Console.WriteLine("Введите число x не равное 0 =");
x= Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число y не равное 0 =");
y= Convert.ToInt32(Console.ReadLine());
if (x>0 && y>0) 
{
    System.Console.WriteLine("первая четверть плоскости графика x>0 и y>0");
}
if (x<0 && y>0) 
{
    System.Console.WriteLine("четвертая четверть плоскости глафика x<0 и y>0");
}
if (x<0 && y<0) 
{
    System.Console.WriteLine("третья четверть плоскоссти графика x<0 и y<0");
}
if (x>0 && y<0) 
{
    System.Console.WriteLine("вторая четверть плоскости графика x>0 и y<0");
}

if (x==0 || y==0) 
{
    System.Console.WriteLine(" 0 вводить нельзя ");
}
