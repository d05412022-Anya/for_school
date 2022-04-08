// 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
//-------------------------------------------------------------------------------
// 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// Console.WriteLine("enter array`s length");
// int length = Convert.ToInt32(Console.ReadLine());
// int[] ar3d = new int[length];
// int count = 0;
// for(int i = 0; i < length; i++){
//     ar3d[i] = new Random().Next(100, 1000);
//     Console.Write(ar3d[i] + " ");
//     if(ar3d[i] % 2 == 0) count++;
// }
// Console.WriteLine();
// Console.WriteLine(count);

//-------------------------------------------------------------------------------
// 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// Console.WriteLine("enter array`s length");
// int l = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[l];
// int sum = 0;
// for(int i = 0; i < array.Length; i++){
//     array[i] = new Random().Next(1, 101);
//     Console.Write(array[i] + " ");
//     if(i % 2 > 0) sum = sum + array[i];
// }
// Console.WriteLine();
// Console.WriteLine(sum);

//-------------------------------------------------------------------------------
// 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("enter array`s length");
int l = Convert.ToInt32(Console.ReadLine());
double[] ar = new double[l];
double min = ar[0];
double max = ar[0];
for(int i = 0; i < ar.Length; i++){
    ar[i] = new Random().Next(-100, 101);
    Console.Write(ar[i] + " ");
    if(ar[i] > max) max = ar[i];
    if(ar[i] < min) min = ar[i];
}
Console.WriteLine();
Console.WriteLine(max - min);