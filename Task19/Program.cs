/*Задача 19

Напишите программу, которая принимает на вход пятизначное число 
и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да   */

using System;
using static System.Console;
Clear();

Write("Введите пятизначное число : ");
string number = ReadLine();


try//только ли числа в введённом значении?
{
    int truNumber = Convert.ToInt32(number);
    if(Math.Abs(truNumber)<10000 || Math.Abs(truNumber)>=100000)//проверка на кол-во символов
    {
        WriteLine("Это не пятизначное число");    
    }
    else if(truNumber>0)
    {
        WriteLine((number[0] == number[4] && number[1] == number[3])?($"{number} -> Да,полиндром!") : $"{number} -> Не полиндром!");    
    }
    else//для отрицательных чисел
    {
        WriteLine((number[1] == number[5] && number[2] == number[4])?($"{number} -> Да,полиндром!") : $"{number} -> Не полиндром!");
    }

}  
catch
{
    WriteLine("Это не число");
}  



