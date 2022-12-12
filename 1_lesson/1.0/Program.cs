/////Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
////a = 5; b = 7 -> max = 7
////a = 2 b = 10 -> max = 10
////a = -9 b = -3 -> max = -3

String s_n_1 = Console.ReadLine();
String s_n_2 = Console.ReadLine();
int n_1 = int.Parse(s_n_1);
int n_2 = int.Parse(s_n_2);
if (n_1 > n_2)
{
    Console.write($"The number {n_1} is greater than {n_2}");
}
else if (n_1 == n_2)
{
    Console.write($"The number {n_1} is equal to the number {n_2}");
}
else
{
    Console.write($"The number {n_2} is greater than {n_1}");
}