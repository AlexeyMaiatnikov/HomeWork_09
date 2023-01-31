/*
Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

using static System.Console;
Clear();
Write("Введите число M: ");
int inParam1 = Convert.ToInt32(ReadLine());
Write("Введите число N: ");
int inParam2 = Convert.ToInt32(ReadLine());
Write(GetAkk(inParam1, inParam2));

int GetAkk(int N, int M)
{

    if (N == 0)
        return M + 1;
    else
    if ((N != 0) && (M == 0))
        return GetAkk(N - 1, 1);
    else
        return GetAkk(N - 1, GetAkk(N, M - 1));


}