/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int GetNumber (string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine (message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода, вы ввели не число. Повторите ввод:");
        }
    }
    return result;
}

int [,] InitRandomMatrix()
{
int m;
int n;   
while (true)
    {
    m = GetNumber ("Введите количество строк");
    n = GetNumber ("Введите количество столбцов");
        if (m>0 && n>0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода, размер матрицы должен быть положительным. Повторите ввод:");
        }
    }

int lowRange =  GetNumber ("Введите нижнюю границу диапазона случайных чисел");
int highRange =  GetNumber ("Введите верхнюю границу диапазона случайных чисел");
int [,] array = new int [m,n];
    
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] =rnd.Next(lowRange,highRange);
        }
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j]);
            if (i != matrix.GetLength(0)-1 || j!= matrix.GetLength(1)-1)
            Console.Write(", ");
        }
        Console.WriteLine();
    }
}
double [] AvarageColumn(int [,] matrix)
{
    Console.WriteLine("Среднее арифметическое по столбцам:");
double [] Avarage = new double [matrix.GetLength(1)] ;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            Avarage [i] = Avarage [i] + matrix [j,i];
        }
        Avarage [i] = Avarage [i]/matrix.GetLength(0);
        Console.Write($" {Avarage [i]}");
        if (i != matrix.GetLength(1)-1)
            Console.Write(", ");
    }
return Avarage;
}
int [,] matrix= InitRandomMatrix();
PrintMatrix(matrix);
double [] AvarageResult= AvarageColumn (matrix);
