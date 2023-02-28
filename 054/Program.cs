// 
class Program
{
    static uint[] GetFibonacciWithWhile(uint n)
    {
        uint[] arr = new uint[n];
        n = 1;
        arr[0] = 0; 
        arr[1] = 1;
        arr[2] = 1;           
        
        while (n > 1)
        {
            n++;
            arr[n] = arr[1] + arr[2];
        }
        return arr;
    }
    public static void Main(string[] args)
    {
        Console.Write("F = ");
        var n = Convert.ToUInt32(Console.ReadLine());
        Console.WriteLine($"{n} числа последовательности Фибоначчи");
        Console.WriteLine(string.Join(" ", GetFibonacciWithWhile(n)));
        GetFibonacciWithWhile(n);
    }
}


