// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Endnumber(int num){

    int result = num / 10 % 10;
    return result;
}
int res = Endnumber(number);
 Console.WriteLine(res);

