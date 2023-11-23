// Задача 64: Задайте значение N. 
// Напишите программу, которая выведет все 
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// class Program
// {
//     static void Main()
//     {
//         int N = 13;
//         Rec(N);
//     }

//     static void Rec(int n)
//     {
//         if (n <= 0)
//         {
//             System.Console.WriteLine("Число должно быть больше нуля");
//             return;
//         }

//         System.Console.Write($"{n}, ");

//         if (n > 1)
//         {
//             Rec(n - 1);
//         }
//     }
// }

// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// class Program
// {
//      static int SumNumbers(int m, int n)
//     {
//         if (m > n)
//         {
//              System.Console.WriteLine("Число M не может быть больше N.");
//              return 0;
//         }

//         int sum = 0;

//         for (int i = m; i <= n; i++)
//         {
//              sum += i;
//         }

//         return sum;
//     }

//     static void Main()
//     {
//         int M = 4; 
//         int N = 8;

//         int sum = SumNumbers(M, N);
//         Console.WriteLine($"M = {M}; N = {N} -> {SumNumbers(M, N)}");
//     }
// }

// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// // m = 3, n = 2 -> A(m,n) = 29

// class Program
// {
//     static int f(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return f(m - 1, 1);
//         }
//         else
//         {
//             return f(m - 1, f(m, n - 1));
//         }
//     }
//     static void Main()
//     {
//         int m = 3;
//         int n = 2;

//         int result = f(m, n);
//         Console.WriteLine($"A({m},{n}) = {result}");
//     }
// }