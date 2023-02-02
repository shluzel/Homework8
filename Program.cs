﻿Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] DescendingRows(int[,] inArray)
{
    int temporary = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int t = 0; t < inArray.GetLength(1); t++)
            {
                if (inArray[i, j] > inArray[i, t])
                {
                    temporary = inArray[i, j];
                    inArray[i, j] = inArray[i, t];
                    inArray[i, t] = temporary;
                }

            }
        }

    }
    return inArray;
}
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Console.WriteLine("Введите количество строк массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] NewArray = GetArray(columns, rows, 0, 100);
PrintArray(NewArray);
Console.WriteLine("Измененный массив: ");
PrintArray(DescendingRows(NewArray));

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

//Напишите программу, которая заполнит спирально массив 4 на 4.