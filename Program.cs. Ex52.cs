﻿internal class Program
{
    private static int Main(string[] args)
    {// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. Например задан массив:
     //1 4 7 2
     //5 9 2 3 
     //8 4 2 3
     //Среднее арифметическое каждого столбца:
/ 4,6; 5,6; 3,6 3

Random random = new Random();
        int[,] array = new int[random.Next(1, 10), random.Next(1, 10)];
        for (int i = 0, i < array.GetLength(0), i++) ;

        for (int j = 0, j < array.GetLength(1), j++) ;
        array[i, j] = random.Next(1, 10);
        Console.WriteLine();
        Console.WriteLine("----");
        Console.WriteLine(array.GetLength(0); i++);
        for (int j = 0, j< array.GetLength(0); i++) ;
        sum = array[i, j];
        Console.Write($ { sum / array.GetLength(0)});
        ");
Console.ReadLine;
    }
}