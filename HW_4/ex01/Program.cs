//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Введите 2 числа. Первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 числа. Второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int resnum = numberA;

int Pownum(int numA, int numB)
{
    for (int i = 1; i < numB; i++)
    {
        resnum = resnum * numA;
    }
    return resnum;
}

int res = Pownum(numberA, numberB);
Console.WriteLine($"Число {numberA}, возведенное в степерь {numberB} равно {res}");