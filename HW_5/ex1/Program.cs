// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int count = 0;
Console.WriteLine("Количество четных чисел в массиве: ");
int[] array = CreateArrayRndInt(8,100, 999);
PrintArray(array);

Console.WriteLine(" -> " + EvenNumQuant(array));

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

int EvenNumQuant(int[] num)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        if (num[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

