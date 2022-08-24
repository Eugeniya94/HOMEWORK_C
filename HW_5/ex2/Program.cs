// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.

Console.WriteLine("Сумма чисел, стоящих в нечетных позициях в массиве ");
int[] array = CreateArrayRndInt(8, -1, 10);
PrintArray(array);

Console.WriteLine(" равна " + SumOddNum(array));


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);

    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
    }
    Console.Write(array[array.Length - 1]);// добавляем последний элемент в массив
    Console.Write("]");
}


int SumOddNum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i+=2)
    {
            sum = sum + array[i];
    }
    return sum;
}
