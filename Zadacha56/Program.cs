// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.

int[,] mass = new int[4, 3];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 3; j++)
    {
        mass[i, j] = new Random().Next(1, 10);
        Console.Write(mass[i, j]+ " ");
    }
Console.WriteLine();
}

int Sum (int[,] mass, int i)
{
  int sumRow = mass[i,0];
  for (int j = 1; j < mass.GetLength(1); j++)
  {
    sumRow += mass[i,j];
  }
  return sumRow;
}

int minSumRow = 0;
int sumLine = Sum(mass, 0);
for (int i = 0; i < mass.GetLength(0); i++)
{
  int SumRow  = Sum(mass, i);
  if (sumLine > SumRow)
  {
    sumLine = SumRow;
    minSumRow = i;
  }
}
Console.WriteLine();
Console.WriteLine($"{minSumRow+1} - строкa с наименьшей суммой элементов");