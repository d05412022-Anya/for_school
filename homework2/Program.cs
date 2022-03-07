/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

void ShowSecond(int num){
    int part1 = num / 100; //4
    int help = part1 * 100; //400
    int help2 = help - num;
    int second = -help2 / 10;
    Console.WriteLine(second);
    }
Console.WriteLine("enter 3digit number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"the second digit of this number is ");
ShowSecond(num);

Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет


void Days(int day){
if(day < 6 && day < 8){
            Console.Write("nope");
        }
    if(day > 5 && day < 8){
            Console.Write("yep");
        }
    if(day > 7){   
        Console.Write("just a number");
    }
}
Console.Write("What day is it?");
int day = Convert.ToInt32(Console.ReadLine());
Days(day);
*/



/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6*/

    
void thirdOne(int num){

    if(100 <= num && num <= 999){
            int part = num / 10;
            int help = part * 10 - num;
            int third = help * -1;
            Console.WriteLine(third);
    }    
    if(num > 999){
        while(num > 999){
        int helpNum = num / 10;
        num = helpNum;
        helpNum +=1;
    }
        int part1 = num / 10;
        int help1 = part1 * 10 - num;
        int third = help1 * -1;
        Console.WriteLine(third);
    }
    if(num < 100){
        Console.WriteLine("there is no third digit");
    }
}
Console.WriteLine("enter number");
int num = Convert.ToInt32(Console.ReadLine());
thirdOne(num);


