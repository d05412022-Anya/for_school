// Задача 1: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

// Задача 2: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 75(0,1,0) 31(0,1,1)
// 45(1,0,0) 53(1,0,1)
// 32(1,1,0) 23(1,1,1)

// Задача 4: Заполните спирально массив 4 на 4.
// На выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7
//--------------------------------------------------------------------------------
Console.WriteLine("enter the number of rows");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of columns");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = FillArray(rows,columns);
int [,] FillArray(int rows, int columns){
int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i, j] = new Random().Next(-9, 10);
        }  
    }
    return array;
}

void PrintArray(int[,] array){
    Console.WriteLine();
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

// Задача 1: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
int [,] SortRowElements(int [,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1) - 1; j++){
            for(int k = j + 1; k < array.GetLength(1); k++){
                if(array[i, j] > array[i, k]){
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
    return array;
}

int[,] array2 = FillArray(rows, columns);
FillArray(rows, columns);
PrintArray(array2);   
//PrintArray(SortRowElements(array2));

//--------------------------------------------------------------------------------
// Задача 2: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int ArrayMinRowSum(int[,] array){
    int minSum = 0;
    int minI = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        int temp = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            temp = temp + array[i, j];
        }
        Console.WriteLine(temp);
        if(minSum > temp || i == 0){
            minSum = temp;
            minI = i;
        }
    }
    Console.WriteLine(minI);
    return minI;
}

ArrayMinRowSum(array2);

//--------------------------------------------------------------------------------
// Задача 3: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.




//--------------------------------------------------------------------------------
// Задача 4: Заполните спирально массив 4 на 4.
