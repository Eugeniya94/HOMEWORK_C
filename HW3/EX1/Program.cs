// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

Console.Write("Введите пятизначное число: ");
int NUM = Convert.ToInt32(Console.ReadLine());

if (NUM < 10000 || NUM > 99999)
{
    Console.WriteLine("Ввели неверное число.");
}
else
{
    bool Palindrom(int num)
    {
        return num / 10000 == num % 10 && ((num / 1000) % 10) == ((num % 100) / 10);
    }
    bool result = Palindrom(NUM);
    Console.WriteLine(result ? $"Число {NUM} является палиндромом" : $"Число {NUM} не является палиндромом");
}
