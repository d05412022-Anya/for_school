void DivCheck(int number, int divisor1, int divisor2){
    if(number % divisor1 == 0 && number % divisor2 == 0)
    {
        Console.WriteLine($"multiple of {divisor1} & {divisor2}");
    }
    else
    {
        Console.WriteLine($"not multiple of {divisor1} & {divisor2}");
    }
}
Console.WriteLine("enter divided ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter first divisor");
int divisor1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter second divisor");
int divisor2 = Convert.ToInt32(Console.ReadLine());

DivCheck(number, divisor1, divisor2);

/*
//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
void Div7_23(int num){
    if(num % 7 == 0 && num % 23 == 0)
    {
        Console.WriteLine("multiple of 7 & 23");
    }
    else
    {
        Console.WriteLine("not multiple of 7 & 23");
    }
}
Console.WriteLine("put yr number ");
int num = Convert.ToInt32(Console.ReadLine());

Div7_23(num);


//напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления
//(первое число всегда больше)


int Div(int number1, int number2){
    int max = number1;
    if(number1 > number2) max = number1;{
        if(max % number2 == 0)
        {
            Console.WriteLine("first number is bigger and multiple of first");
        }
        else
        {
            Console.WriteLine($"first is bigger, first is NOT multiple of second, the reminder of division is {max % number1}");
        }
        }
        
    if(number2 > number1) max = number2;{
        if(max % number1 == 0)
        {
            Console.WriteLine("second number is bigger and multiple of first");
        }
        else
        {
            Console.WriteLine($"second is bigger, second is NOT multiple of first, reminder of div {max % number1}");
        }
        }
        
    if (number1 == number2)
    {
        Console.WriteLine("numbers are equal");
    }
    }
   

Console.WriteLine("put number 1 ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("put number 2 ");
int number2 = Convert.ToInt32(Console.ReadLine());

Div(number1, number2);









//Напишите программу, которая выводит случайное число из отрезка [10, 99] 
//и показывает наибольшую цифру числа, т.е. если это 48, то 8

int num = new Random().Next(10, 99);
int FindMaxNum(int num)
{
    int n1 = num % 10;
    int n2 = num / 10;

    if(n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}

Console.WriteLine("Current number is " + number + " max part is " + FindMaxNum(number));


//Напишите программу, которая выводит 
//случайное трёхзначное число и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);// до тысячи, последний не включён
int DeleteSecondNum(int number){
    int n1 = (number/100)*10;
    int n2 = number%10;
    return n1 + n2;

}
Console.WriteLine(number + "-->" + DeleteSecondNum(number));


//напишите программу, которая будет принимать на вход два числа и выводить,
//является ли второе число кратным первому. 
//Если второе число не кратно числу первому, то программа выводит остаток от деления
//(первое число всегда больше)


void Div(int number1, int number2){
    if(number1 < number2){
        int a = number1;
        number1 = number2;
        number2 = a;
    }
    if(number2 % number1 == 0)
    {
        Console.WriteLine("second multiple of first");
    }
    else
    {
        Console.WriteLine(number2 % number1);
    }
 }

Console.WriteLine("put number 1, the small one ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("put number 2, the bigger one ");
int number2 = Convert.ToInt32(Console.ReadLine());

Div(number1, number2);
*/