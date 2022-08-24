// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным
// элементами массива.


Console.Write("Заданный массив: ");
double[] array = CreateArrayRndDouble(8, -1, 1);
PrintArray(array);
Console.WriteLine();

Console.WriteLine($"Разница между максимальным и минимальным числом равна " + DifMaxMinNum(array));

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((rnd.NextDouble() * 10 * ((max - min) + min)), 2);
    }

    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}


double DifMaxMinNum(double[] array)
{
    double max = 0;
    double min = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    double result = max - min;
    double res = Math.Round(result, 2);
    return res;
}