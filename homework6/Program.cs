// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива.
// Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями

// 3, 4 ->
// 1 1 1 1
// 1 0 0 1
// 1 1 1 1
//-------------------------------------------------------------------------
// Задача 1: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// void Quantity(int nums){
//     int count = 0;
//     for(int i = 0; i <= nums; i++){
//         Console.Write("enter next number ");
//         int userNum = Convert.ToInt32(Console.ReadLine());
//         if(userNum > 0) count++;
//     }
// Console.WriteLine($"quantity of positives numbers is {count}");
// }

// Console.WriteLine("enter quantity of your numbers");
// int m = Convert.ToInt32(Console.ReadLine());
// Quantity(m);


//-------------------------------------------------------------------------
// Задача 2: Пользователь вводит с клавиатуры кол-во строк и столбцов для массива.
// Вывести массив в виде матрицы, создав "рамку" из единиц, а внутреннюю зону матрицы заполнить нулями
void ZeroOneFrame(int [,] matrix){
    for(int i = 0; i < matrix.GetLength(0); i++) {
        for(int j = 0; j < matrix.GetLength(1); j++){
            if(i == 0 || i == matrix.GetLength(0) - 1 || j == 0 || j == matrix.GetLength(1) - 1) matrix[i, j] = 1;
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

Console.WriteLine("enter enter the number of rows");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter enter the number of columns");
int b = Convert.ToInt32(Console.ReadLine());
int [,] array = new int [a, b];
ZeroOneFrame(array);