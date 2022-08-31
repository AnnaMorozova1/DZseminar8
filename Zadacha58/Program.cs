// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.

int[,] mass = new int[2, 2];
System.Console.WriteLine("Первая матрица: ");
for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i, j] = new Random().Next(1, 10);
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}

int[,] array = new int[2, 2];
Console.WriteLine("Вторая матрица: ");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int[,] matrix = new int[2, 2];
Console.WriteLine("Произведение матриц: ");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
      for (int k = 0; k < mass.GetLength(1); k++)
      {
        sum += mass[i,k] * array[k,j];
      }
      matrix[i,j] = sum;
        
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
