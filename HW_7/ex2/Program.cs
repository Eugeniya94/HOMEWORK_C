// Задача 50. Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] matr = CreateMatrixRndInt(3,4,1,10);
PrintMatrix(matr);

Console.WriteLine("Введите позицию элемента в строке: ");
int stringN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите позицию элемента в столбце: ");
int colN = Convert.ToInt32(Console.ReadLine());

string FindPosElem(int[,] matrix, int str, int col)
{
if (str > matrix.GetLength(0) || col > matrix.GetLength(1))
{
    Console.WriteLine("В заданной позиции элемент отсутствует");
}

    return ($"значение элемента {str} строки и {col} столбца равно {matrix[str-1,col-1]}");

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 4},");// добавили отступ 4
            else Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("]");
    }
}


string res = FindPosElem(matr, stringN, colN);
Console.WriteLine(res);