﻿// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223->3 

int Countnum()
{
    int count = 0;
    String word;

    while (true)
    {
        Console.Write("Output any number: ");
        word = Console.ReadLine();

        if (word == "") return count;
        else if (int.Parse(word) >0) count += 1;
    }
}

Console.Write(Countnum());