// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Clear();


int a = InputNumbers("Введите число строк первой матрицы: ");
int b = InputNumbers("Введите число столбцов первой матрицы,также оно будет равно количеству строк второй матрицы: ");
int c = InputNumbers("Введите число столбцов второй матрицы: ");
int min = 1;
int max = 100;

int[,] firstMartrix = new int[a, b];
CreateArray(firstMartrix);
Console.WriteLine();
WriteArray(firstMartrix);
Console.WriteLine("_______________");

int[,] secomdMartrix = new int[b, c];
CreateArray(secomdMartrix);
WriteArray(secomdMartrix);
Console.WriteLine("_______________");
Console.WriteLine("Произведение двух матриц.");
Console.WriteLine();

int[,] resultMatrix = new int[a, c];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteArray(resultMatrix);
Console.WriteLine("_______________");

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secomdMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(min , max );
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
// int a = 0;
// int b = 0;
// int[,] CreateFirstMatrixRndInt(int m, int n, int min , int max)
// {
//      int[,] arr = new int[m, n];
//      Random rnd = new Random();

//      for (int i = 0; i < arr.GetLength(0); i++)
//      {
//          for (int j = 0; j < arr.GetLength(1); j++)
//          {
//              arr[i, j] = rnd.Next(min, max + 1);
//          }
//      }
//      return arr;
// }

// void PrintFirstMatrix(int[,] arr)
//  {
//      for (int i = 0; i < arr.GetLength(0); i++)
//      {
//          for (int j = 0; j < arr.GetLength(1); j++)
//          {
//            if (j == 0) Console.Write("|");
//            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i,j], 4} | ");
//            else Console.Write($"{arr[i,j], 3} | ");
//          }
//          Console.WriteLine();
//      }
//  }
//  Console.ReadLine();

// int[,] CreateSecondMatrixRndInt2(int m2, int n2, int min , int max)
//  {
//      int[,] arr = new int[m2, n2];
//      Random rnd = new Random();

//      for (int i = 0; i < arr.GetLength(0); i++)
//      {
//          for (int j = 0; j < arr.GetLength(1); j++)
//          {
//              arr[i, j] = rnd.Next(min, max + 1);
//          }
//      }
//      return arr;
//  }

// void PrintSecondMatrix2(int[,] arr)
//  {
//      for (int i = 0; i < arr.GetLength(0); i++)
//      {
//          for (int j = 0; j < arr.GetLength(1); j++)
//          {
//            if (j == 0) Console.Write("|");
//            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i,j], 4} | ");
//            else Console.Write($"{arr[i,j], 3} | ");
//          }
//          Console.WriteLine();
//      }
        
//  }
//  Console.ReadLine();

// int CompositionMatrix(int[,] SecondMatrix2, int[,] FirstMatrix,int[,] PrintFirstMatrix, int[,] PrintSecondMatrix2)
// {
//     for (j = 0; j < 3; j++)
//      {
//       a[i, j] = m[i, j] * m2[i, j];
//       Console.Write(a[i, j]);
//       Console.WriteLine("\n");
//         for (i = 0; i < 3; i++) 
//         {
//           b[i, j] = n[i, j] * n2[i, j];
//           Console.Write(m1[i, j]);
//           Console.WriteLine("\n");
//         }
//       }
//       return arr;
// }

// void PrintCompositionMatrix(int[,] arr)
// {
// for (int i = 0; i < arr.GetLength(0); i++)
//      {
//          for (int j = 0; j < arr.GetLength(1); j++)
//          {
//            if (j == 0) Console.Write("|");
//            if (j < arr.GetLength(1) - 1) Console.Write($"{arr[i,j], 4} | ");
//            else Console.Write($"{arr[i,j], 3} | ");
//          }
//          Console.WriteLine();
//      }
// }     
//  Console.ReadLine();


// int[,] arrayResult1 = CreateFirstMatrixRndInt(4, 4, 1, 100);
// PrintFirstMatrix(arrayResult1);
// Console.WriteLine("___________________________");
// int[,] arrayResult2 = CreateSecondMatrixRndInt2(4, 4, 1, 100);
// PrintSecondMatrix2(arrayResult2);
// CompositionMatrix();
// PrintCompositionMatrix(arrayResultComposition);