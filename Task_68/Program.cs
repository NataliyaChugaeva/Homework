// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29.



// int a = InputInt("Введите положительное число A: ");
// int b = InputInt("Введите положительное число B: ");
// Console.WriteLine($"A({a}, {b}) = {Akkerman(a, b)}");

// int InputInt(string output)
// {
//  Console.Write(output);
//  return int.Parse(Console.ReadLine());
// }

// int Akkerman(int a, int b)
// {
//     if (a == 0)
//         return b + 1;
//     if (a > 0 && b == 0)
//         return Akkerman(a - 1, 1);
//     else
//         return Akkerman(a - 1, Akkerman(a, b - 1));
// }

int m = InputToInt32("Введите M: ");
int n = InputToInt32("Введите N: ");
Console.Write($"A({m}, {n}) = {Akkerman(m, n)}");

int InputToInt32(string output)
{
 Console.Write(output);
 return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}