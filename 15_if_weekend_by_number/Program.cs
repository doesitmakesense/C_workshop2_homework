﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели от 1 до 7 и я скажу, выходной ли это: ");
int x = int.Parse(Console.ReadLine());

if (x > 0 & x < 8)
{
    if (x == 6 | x == 7)
    {
        Console.Write("Мамой клянусь, это выходной! УРАААААААА!!!");
    }
    else
        Console.Write("Присядь... У меня для тебя тяжелые новости... Это не выходной :( ");
}
else Console.Write("Обмануть меня думаешь? А не выйдет!");