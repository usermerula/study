﻿Console.WriteLine("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());;

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{i*i*i} ");
}


