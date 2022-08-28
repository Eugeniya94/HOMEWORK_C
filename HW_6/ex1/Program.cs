// // Задача 41: Пользователь вводит с клавиатуры M чисел.
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Введите количество чисел, которое вы собираетесь ввести: ");
int number = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = new int[number];

void InpNumbers(int num)
{
for (int i = 0; i < num; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int OverZeroNum(int[] arrayNumbers)
{
  int count = 0;
  for (int i = 0; i < arrayNumbers.Length; i++)
  {
    if(arrayNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InpNumbers(number);

Console.WriteLine($"Количество чисел больше 0: {OverZeroNum(arrayNumbers)} ");
