﻿/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/
using System;
using static System.Console;
Clear();

Write ("Число Х1:  ");
int x1 = Convert.ToInt32(ReadLine());

Write ("Число Y1:  ");
int y1 = Convert.ToInt32(ReadLine());

Write ("Число Z1:  ");
int z1 = Convert.ToInt32(ReadLine());

WriteLine();

Write ("Число X2:  ");
int x2 = Convert.ToInt32(ReadLine());

Write ("Число Y2:  ");
int y2 = Convert.ToInt32(ReadLine());

Write ("Число Z2:  ");
int z2 = Convert.ToInt32(ReadLine());

double x = Math.Pow(x1-x2 ,2);
double y = Math.Pow(y1-y2 ,2);
double z = Math.Pow(z1-z2 ,2);
double distance = Math.Sqrt(x+y+z);

WriteLine($"\nРасстояние равно: {distance:f2}\n");
