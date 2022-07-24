// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.WriteLine("Задайте количество строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 100;
int[,] arr = new int[a, b];
Console.WriteLine();
CreateArray(arr);
PrintArray(arr);

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) - 1; j++)
    {
        for (int c = 0; c < arr.GetLength(1) - 1; c++)
        {
            if (arr[i, c] < arr[i, c + 1])
            {
                int temp = 0;
                temp = arr[i, c];
                arr[i, c] = arr[i, c + 1];
                arr[i, c + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
PrintArray(arr);

void CreateArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(min, max + 1);
    }
  }
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" | ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " | ");
        }
        Console.Write(" ");
        Console.WriteLine("");
    }
}