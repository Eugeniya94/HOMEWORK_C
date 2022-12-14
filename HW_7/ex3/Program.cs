// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] matr = CreateMatrixRndInt(3,4,1,10);
PrintMatrix(matr);
double[] aver = AverageInCol(matr);
Console.WriteLine(aver);


double[] AverageInCol(int[,]matrix)
{
     double avarage = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
   
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        avarage = (avarage + matrix[i,j]);
    }
    avarage = avarage / matrix.GetLength(1);
}
return new double[]{avarage};
}

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)// row
    {
        for (int j = 0; j < matrix.GetLength(1); j++)// col
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }


    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");// добавили отступ 4
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}