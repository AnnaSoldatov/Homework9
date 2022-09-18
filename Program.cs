// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные чиса в промежутке от M до N.

// // Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }

// // Рекурсия числа от M до N
// string NumMN(int M, int N)
// {
//     if (M >= N)
//     {
//         return N.ToString();
//     }
//     else
//     {
//         return M + ", " + NumMN(M + 1, N);
//     }
// }


// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int M = ReadData("Введите число M: ");
// int N = ReadData("Введите число N: ");
// string res = (M < N) ? NumMN(M, N) : NumMN(N, M);
// PrintData("Числа от M до N: ", res);

//Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

// Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }

// // Рекурсивный поиск суммы чисел от M до N
// int SumMN(int M, int N)
// {
//     if (M >= N)
//     {
//         return N;
//     }
//     else
//     {
//         return M + SumMN(M + 1, N);
//     }
// }


// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int M = ReadData("Введите число M: ");
// int N = ReadData("Введите число N: ");
// int sum = 0;
// if(M<N) sum = SumMN(M,N);
// else sum = SumMN(N,M);
// PrintData("Сумма чисел от M до N: ", sum.ToString());


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.

// Запрос данных от пользователя
// int ReadData(string line)
// {
//     Console.Write(line);
//     int num = int.Parse(Console.ReadLine() ?? "1");
//     return num;
// }

// // Рекурсивное вычисление функции Аккермана
// static int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if(m != 0 && n == 0)
//     {
//         return Akkerman(m-1,1);
//     }
//     else if(m > 0 && n > 0)
//     {
//         return Akkerman(m-1, Akkerman(m, n-1));
//     }
//     return Akkerman(m,n);
// }


// //Вывод результата
// void PrintData(string prefix, string num)
// {
//     Console.WriteLine(prefix + num);
// }

// int m = ReadData("Введите число m: ");
// int n = ReadData("Введите число n: ");
// int res = Akkerman(m, n);
// PrintData("Числа от M до N: ", res.ToString());

