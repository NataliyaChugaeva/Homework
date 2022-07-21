// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

Console.Write("Введите строку:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец:");
int b = Convert.ToInt32(Console.ReadLine());

int n = 5; // размер массива
int m = 7; // размер массива
Random rnd = new Random();
int[,] arr = new int[n, m];
Console.WriteLine("Исходный массив:");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
       for (int j = 0; j < arr.GetLength(1); j++)
        {
          arr[i, j] = rnd.Next(10, 99);
          Console.Write("{0} ", arr[i, j]);
        }
        Console.WriteLine();
    }
   if (a < 0 | a > arr.GetLength(0) - 1 | b < 0 | b > arr.GetLength(1) - 1)
    {
     Console.WriteLine("Элемент не существует");
    }
   else
    {
     Console.WriteLine("Значение элемента массива = {0}", arr[a, b]);
    }
Console.ReadLine();
 
        


// int[,] CreateMatrixRndInt(int m, int n, int min , int max)
// {
//     int[,] arr = new int[m, n];
//     Random rnd = new Random();

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return arr;
// }

// void PrintMatrix(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//           if (j == 0) Console.Write("|");
//           if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i,j], 3} | ");
//           else Console.Write($"{arr[i,j], 3} | ");
//         }
//         Console.WriteLine();
//     }
// }
