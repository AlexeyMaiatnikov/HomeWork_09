/*
Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

using static System.Console;
Clear();
Write("Введите число M: ");
int inParam1 = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int inParam2 = Convert.ToInt32(ReadLine());
Write(GetSum(inParam1, inParam2));




int GetSum(int M, int N)
{

    if (M == N) return M;    
    return N + GetSum(M, N - 1);

}

