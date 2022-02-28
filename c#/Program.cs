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
*/

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