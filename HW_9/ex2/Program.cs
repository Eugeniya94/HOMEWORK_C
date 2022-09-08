// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());


int SumFromN1ToN2(int num1, int num2)
{
    int res = num1;
    if (num1 == num2)
        return 0;
    else
    {
        num1++;
        res = num1 + SumFromN1ToN2(num1, num2);
        return res;
    }
}
int result = SumFromN1ToN2(number1,number2);
Console.WriteLine($"Сумма чисел от {number1} до {number2} равна {result+number1}");
 