Console.Write ("введите целое число");
int value = Convert.ToInt32 (Console.ReadLine());// пытается записать тип string в int, поэтому беда, конвертируем в int

int squareNumber = value * value;

Console.WriteLine("квадрат данного числа равен ");
Console.WriteLine (squareNumber);