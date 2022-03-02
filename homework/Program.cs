// Задача 1: Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее,а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*
Console.WriteLine("введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1 > number2)
    {
        Console.WriteLine("первое число больше");
    }

    if(number1 == number2)
    {
        Console.WriteLine("они равны, хитрец");
    }

    if(number2 > number1)
    {
    Console.WriteLine("второе число больше");
    }


*/

//Задача 2: Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("введите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());
int max = number1;
    if(number1 > number3 && number1 > number2)
        {
            Console.WriteLine($"число {number1} наибольшее");
        }
    if(number2 > number3 && number2 > number1)
        {
            Console.WriteLine($"число {number2} больше остальных");
        }
    
    if(number3 > number1 && number3 > number2)
        {
            Console.WriteLine($"число {number3} самое большое");
        }
    if(number1 == number2 | number2 == number3 | number1 == number3)
        {
            Console.WriteLine("что-то из этого равно");
        }
    



//Задача 3: Напишите программу, которая на вход принимает число 
//и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

//Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
