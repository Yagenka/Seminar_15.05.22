﻿// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет, 23432 -> да, 12821 -> да

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine((n / 10000 == n % 10 && (n / 1000) % 10 == n / 10 % 10) ? "Палиндром" : "Не палиндром");