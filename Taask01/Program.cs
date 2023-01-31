/*
Задача 64: Напишите программу, которая реализует рекурсивный метод вывода всех натуральных чисел в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
using static System.Console;
Clear();
Write("Введите число N: ");
int inParam = Convert.ToInt32(ReadLine());



Natural(inParam);

void Natural(int N)
{
    if (N != 0)
    {
        Write($"{N} ");
        Natural(N - 1);
        
    }
}