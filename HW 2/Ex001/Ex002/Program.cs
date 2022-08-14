// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
//что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int firstnum = number/100;

string Endnumber(int num)
{
    while(num>=100 && num<=999)
    {
        int firstnum = num/100;
    }
        if(firstnum % 100 == 0) return "Третьей цифры нет.";
        
      int result = firstnum % 10;
        
    return ($"Третья цифра {result}");
    }

string endnumber = Endnumber(number);
Console.WriteLine(endnumber);



