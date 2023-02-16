/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
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
    m = GetNumber ("Введите m");
    n = GetNumber ("Введите n");
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

double [,] matrix= InitRandomMatrix();
PrintMatrix(matrix);
