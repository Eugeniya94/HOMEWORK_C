// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 3 n = 2 -> A(m,n) = 29

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int AkkermanFunct(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0 && num1 > 0)
    {
        return AkkermanFunct(num1 - 1, 1);
    }
    else
    {
        return (AkkermanFunct(num1 - 1, AkkermanFunct(num1, num2 - 1)));
    }
}
int result = AkkermanFunct(number1,number2);
Console.WriteLine($"Результат вычисление чисел {number1} и {number2} по функции Аккермана равен: {result}");