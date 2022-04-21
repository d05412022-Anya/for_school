// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//   Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
//   1 7 -> такого числа в массиве нет

// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
//---------------------------------------------------------------------------------------
// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
// void ArrayDouble(int row, int column){
//     double[,] array = new double[row, column];
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             array[i, j] = new Random().NextDouble() * 10;
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine(" ");
//     }
// }
// Console.WriteLine("enter the number of rows");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("enter the number of columns");
// int n = Convert.ToInt32(Console.ReadLine());
// ArrayDouble(m, n);
//---------------------------------------------------------------------------------------
// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.



// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.
void ArrayArithmeticMean(int row, int column){
    int [,] array = new int[row, column];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            array[i,j] = new Random().Next(-90, 100);
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine(" ");
    }   
for (int i = 0; i < array.GetLength(1); i++){
    double arithmeticMean = 0;
    for (int j = 0; j < array.GetLength(0); j++){
             arithmeticMean = arithmeticMean + Math.Abs(array[j, i]);
    }  
    arithmeticMean = arithmeticMean / array.GetLength(0);
    Console.WriteLine($"the arithmetic mean of column {i} is {arithmeticMean}");
}
}   
Console.WriteLine("enter the number of rows");
int m = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("enter the number of columns");
int n = Convert.ToInt32(Console.ReadLine());
ArrayArithmeticMean(m, n);