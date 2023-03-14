// 
// Задача 93: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц  а) простым поэлементным перемножением

int [,] matrix1 = new int [5,5];
int [,] Matrix2 = new int [5,5];
Random random = new Random();
InitArray(matrix1);
PrintArray(matrix1);
System.Console.WriteLine();
InitArray(Matrix2);
PrintArray(Matrix2);
int [,] resultMatrix = new int [5,5];
MatrixMultiplication(matrix1, Matrix2, resultMatrix);
System.Console.WriteLine();
PrintArray(resultMatrix);




void InitArray ( int [,] array)
{
  for (int rad = 0; rad < array.GetLength(0); rad++)
  {
    for (int stolb = 0; stolb<array.GetLength(1); stolb++)
    {
      array[rad,stolb] = random.Next(1,10);
    }
  }
}

void MatrixMultiplication ( int [,] firstArray, int [,] secondArray, int [,] resultArray)
{
  if (firstArray.GetLength(0)!=secondArray.GetLength(0) || firstArray.GetLength(1)!=secondArray.GetLength(1))
  System.Console.WriteLine("Разные матрицы");
  else
    for (int rad = 0; rad < firstArray.GetLength(0); rad++)
  {
    for (int stolb = 0; stolb<firstArray.GetLength(1); stolb++)
    {
      resultArray[rad,stolb] = firstArray[rad,stolb] * secondArray[rad,stolb];
    }
  }
}

void PrintArray (int [,] array)
{
  for (int rad = 0; rad < array.GetLength(0); rad++)
  {
    for (int stolb = 0; stolb<array.GetLength(1); stolb++)
    {
      System.Console.Write($"{array[rad,stolb],-5}");
    }
    System.Console.WriteLine();
  }
}