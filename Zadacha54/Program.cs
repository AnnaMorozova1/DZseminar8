// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
// убыванию элементы каждой строки двумерного массива.

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int [,] mass = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        mass[i, j] = new Random().Next(1,10);
     
        Console.Write(mass[i, j] + " ");
    }
    Console.WriteLine();
}
    
static void SortRow(int[,] m, int r)
{
    for (int i = 0; i < m.GetLength(1); i++)
        for (int j = i + 1; j < m.GetLength(1); j++)
            if (m[r, i] > m[r, j])
            {
                int tmp = m[r, i];
                m[r, i] = m[r, j];
                m[r, j] = tmp;
            }
}

for (int i = 0; i < mass.GetLength(0); i++)
SortRow(mass, i);
Console.WriteLine();
Console.WriteLine("Измененный массив: ");

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    Console.Write(mass[i, j] + " ");
    Console.WriteLine();
}
   


