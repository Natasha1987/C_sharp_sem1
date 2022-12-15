// Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

string NumSec(int num)
{
    if ((-1000 < num && num < -99) || (num < 1000 && num > 99))
      return $"{num / 10 % 10};
    return "The number is not three-digital";
}
Console.WriteLine(NumSec(int.Parse(Console.ReadLine())));

