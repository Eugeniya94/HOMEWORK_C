// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstnum = number/100;

int Endnumber(int num)
{
    while(num>=100 && num<=1000)
    {
        int firstnum = num/100;
    }
        if(firstnum % 100 == 0) return -1;
        int result = firstnum % 10;
        
    return result;
    }

int endnumber = Endnumber(number);
Console.WriteLine(endnumber);


