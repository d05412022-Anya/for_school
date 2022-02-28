/*
//программа должна выводить квадрат целого числа
решение 1:
int x = new Random().Next(1,11); // 1 2 3 4 .. 10
Console.WriteLine (x);
int result = x*x;
Console.WriteLine (result);

решение общее:
Console.Write ("введите целое число");
int value = Convert.ToInt32 (Console.ReadLine());// пытается записать тип string в int, поэтому беда, конвертируем в int

int squareNumber = value * value;

Console.WriteLine("квадрат данного числа равен ");
Console.WriteLine (squareNumber);


// программа должна принять 2 числа и проверить, является ли первое число квадратом второго

Console.Write ("введите число 1 ");
int number1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("введите число 2 ");
int number2 = Convert.ToInt32 (Console.ReadLine());
int squareNumber2 = number2 * number2;

if(Convert.ToBoolean(number1 == number2 * number2))
{
    Console.Write ("да, первое число это квадрат второго");
}
else
{
    Console.Write ("это просто числа, отстань");
}



// Напишите программу, которая будет выдавать название дня недели по заданному номеру

Console.Write("Какой этот день по счёту? ");
int day = Convert.ToInt32(Console.ReadLine());
if(day == 1) 
    {
      Console.Write("это понедельничек");
    }

    if(day == 2) 
    {
        Console.Write("вторничек");
    }

    if(day == 3) 
    {
      Console.Write("среда");
    }

    if(day == 4) 
    {  
        Console.Write("рыбный день");
    }

    if(day == 5) 
    {
        Console.Write("пятница");
    }

    if(day == 6) 
    {
        Console.Write("субботка");
    }

    if(day == 7) 
    {
        Console.Write("воскресенье");
    }

    else
    {   
    Console.Write("твой личный день");
    }


Console.Write("введите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
    {
        case 1:
        {
            Console.WriteLine("понедельник");
            break;
        }
        case 2:
        {
            Console.WriteLine("вторник");
            break;
        }
        default:
        {
            Console.WriteLine("неа");
        }
        

    }











//Напишите программу, которая на вход принимает одно число (N), а 
//на выходе показывает все натуральные целые числа в промежутке от -N до N


Console.Write ("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
int negN = n*(-1);
while(negN <= n)
{
    Console.WriteLine(negN);
    negN++;    //negN+=3 - увеличение на 3
}
*/


