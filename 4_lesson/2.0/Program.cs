// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int SumNums(int num)
{
    int n_sum = 0;
    while (num > 0)
    {
        n_sum += num % 10;
        num /=10;
    }
    return n_sum;
}
Console.WriteLine(SumNums(int.Parse(Console.ReadLine())));
