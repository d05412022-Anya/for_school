// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
// 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

/*
// 1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
void myPow(int num1, int num2){
    int index = 0;
    int result = num1;
    if(num2 == 0) result = 1;
    for(index = 1; index < Math.Abs(num2); index++) {
            result = result * num1;
        }
    Console.WriteLine(result);
}

Console.WriteLine("enter first number ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second number ");
int number2 = Convert.ToInt32(Console.ReadLine());
myPow(number1, number2);

//2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void digitSum(int number){
    int sum = number % 10;
    while (Math.Abs(number) > 0){
        number = number / 10;
        sum = sum + number % 10;
    }
    Console.WriteLine($"sum of digits in this number is {Math.Abs(sum)}");
    
}
Console.WriteLine("enter number");
int num = Convert.ToInt32(Console.ReadLine());
digitSum(num);
*/


// 3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
void letsFillArray(int size){
    int index = 0;
    int[] array = new int [size];
    while(index < array.Length){
        Console.WriteLine("enter next item");
        array[index] = Convert.ToInt32(Console.ReadLine());
        index++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", array));
}
Console.WriteLine("what array length do you want?");
int yrLength = Convert.ToInt32(Console.ReadLine());
letsFillArray(yrLength);