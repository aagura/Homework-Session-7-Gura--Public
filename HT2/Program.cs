/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
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

double [,] InitRandomMatrix()
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
double[,] array = new double[m,n];
    
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i,j] =lowRange+ rnd.NextDouble()*(highRange-lowRange);
        }
    }
    return array;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0:0.00}", matrix[i,j]);
            if (i != matrix.GetLength(0)-1 || j!= matrix.GetLength(1)-1)
            Console.Write(", ");
        }
        Console.WriteLine();
    }
}
void GetNumberFromMatrix (double[,] matrix)
{
int pozI = GetNumber("Введите номер строки");
int pozJ = GetNumber ("Введите номер столбца");
if (pozI>matrix.GetLength(0) -1|| pozJ>matrix.GetLength(1)-1 || pozI<0 || pozJ<0)
Console.WriteLine("Такого элемента в массиве нет");
else
 {
    Console.WriteLine ($"Элемент [{pozI}, {pozJ}]:");
    Console.WriteLine ("{0:0.00}",matrix[pozI,pozJ]);
 }
}
double [,] matrix= InitRandomMatrix();
PrintMatrix(matrix);
GetNumberFromMatrix (matrix);

