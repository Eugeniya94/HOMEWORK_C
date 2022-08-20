// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

int SumNumbers(int num)
{
    while (num > 0)
    {
        int num1 = num % 10;
        sum = sum + num1;
        num = num / 10;
    }
    return sum;
}

int result = SumNumbers(number);
Console.Write($"Сумма всех цифр в числе равна {result}");


