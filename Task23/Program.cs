/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

using System;
using static System.Console;
Clear();
Write("Введите число: ");
int N = Convert.ToInt32(ReadLine());

cubeTable(N);

int cubeTable(int c)
{
    int cubeNumber = 0;
    for(int i = 1; i<c ; i++)
    {
        Write($"{Math.Pow(i ,3)}, ");

    }
    Write($"{Math.Pow(c ,3)}.\n");
    return cubeNumber;
}
