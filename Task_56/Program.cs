// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.Clear();

Console.WriteLine("Нужно задать квадратный массив,поэтому вводите равное количество строк и столбцов.");
Console.WriteLine("Задайте количество строк массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов массива: ");
int b = Convert.ToInt32(Console.ReadLine());
int min = 1;
int max = 100;

int[,] arr = new int[a, b];
CreateArray(arr);
WriteArray(arr);

int minSumLine = 0;
int sumLine = SumLineElements(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(arr, i);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}
Console.WriteLine("_________________");
Console.WriteLine($"{minSumLine+1} - строкa с наименьшей суммой элементов:({sumLine})");


int SumLineElements(int[,] arr, int i)
{
  int sumLine = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumLine += arr[i,j];
  }
  return sumLine;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(min, max);
    }
  }
}

void WriteArray (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
  }
}