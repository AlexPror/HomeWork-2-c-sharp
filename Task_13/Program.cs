/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Проверка введенного числа {number} на трёхзначность");
int count = 1;
int i = 10;
while (number / i > 0)
{
    i*=10;
    count++; 
}
Console.WriteLine($"Введённое число имеет {count} порядок");

// ------- Если число имеет менее трёх порядков -------
if (count < 3 )
    Console.WriteLine($"Третьей цифры нет");

// ------- Если число имеет третий порядок -------
int num = number % 10;
if (count == 3)
    Console.WriteLine($"Третья цифра числа {number}: {num}");

// ------- Если число имеет более трёх порядков -------
int var = Convert.ToInt32(Math.Pow(10, (count-3)));
int digit = number / var % 10;
if (count > 3)
    Console.WriteLine($"Третья цифра числа {number}: {digit}");