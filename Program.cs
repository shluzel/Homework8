Console.Clear();
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
int[,,] Get3DimensionalArray(int a, int b, int c)
{
    int[,,] result = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            int t = 0;
            while (t < c)
            {
                int Number = new Random().Next(10, 100);
                if (SameNumber(result, Number)) continue;
                result[i, j, t] = Number;
                t++;
            }

        }
    }
    return result;
}
bool SameNumber(int[,,] inArray, int element)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int t = 0; t < inArray.GetLength(2); t++)
            {
                if (inArray[i, j, t] == element) return true;
            }
        }
    }
    return false;
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
void Print3DArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int t = 0; t < inArray.GetLength(2); t++){
                Console.Write($"{inArray[i, j, t]} ({i},{j},{t})");
                Console.WriteLine();
            }
            
        }
        
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
string FindNumber(int[,] inArray, int Numb)
{
    int x = 0;
    int y = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i, j] == Numb)
            {
                x = i;
                y = j;
            }

        }
    }
    if (x == 0 && y == 0)
    {
        return ($"Элемента {Numb} в массиве нет.");
    }
    else
    {
        return ($"Элемент {Numb} стоит в массиве на {x} строке в {y} столбце");
    }

}
int MinSuminRows(int[,] inArray)
{
    int min = 0;
    int row = 0;
    for (int i = 0; i < inArray.GetLength(1); i++)
    {
        min = min + inArray[0, i];
    }

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i, j];
        }
        if (sum < min)
        {
            min = sum;
            row = i + 1; //Выводим номер строки, понятный для пользователя (если бы строки начинали нумероваться с 1)
        }

    }
    return row;
}
int[,] MultiplyMatrix(int[,] Array1, int[,] Array2)
{
    int[,] result = new int[Array1.GetLength(0), Array2.GetLength(1)];
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array2.GetLength(1); j++)
        {
            for (int t = 0; t < Array1.GetLength(1); t++)
            {
                result[i, j] += Array1[i, t] * Array2[t, j];
            }
        }
    }
    return result;
}
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.WriteLine("Введите количество строк массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] NewArray = GetArray(columns, rows, 0, 100);
PrintArray(NewArray);
Console.WriteLine("Измененный массив: ");
PrintArray(DescendingRows(NewArray));
*/

//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.WriteLine("Введите количество строк массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] NewArray = GetArray(columns, rows, 0, 10);
PrintArray(NewArray);
Console.WriteLine($"Строка с наименьшей суммой элементов под номером: {MinSuminRows(NewArray)}");
*/

//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Console.WriteLine("Введите количество строк массива: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк массива: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
if (columnsA != rowsB)
{
    Console.WriteLine("Перемножить матрицы не получится.");
}
else
{
    int[,] A = GetArray(rowsA, columnsA, 0, 10);
    int[,] B = GetArray(rowsB, columnsB, 0, 10);
    Console.WriteLine();
    PrintArray(A);
    Console.WriteLine();
    PrintArray(B);
    Console.WriteLine();
    PrintArray(MultiplyMatrix(A, B));
}
*/

//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine("Введите первую размерность массива: ");
int FirstDim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую размерность массива: ");
int SecondDim = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью размерность массива: ");
int ThirdDim = Convert.ToInt32(Console.ReadLine());
int [,,] New3DArray = Get3DimensionalArray(FirstDim, SecondDim, ThirdDim);
Print3DArray(New3DArray);

//Напишите программу, которая заполнит спирально массив 4 на 4.