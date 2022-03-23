//19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

//21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

//23:  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125



//21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double getDistance3D(double x1, double y1, double x2, double y2, double z1, double z2)
{
    double xDistance = x2 - x1;
    double yDistance = y2 - y1;
    double zDistance =  z1 - z2;
    return Math.Sqrt(Math.Pow(xDistance, 2) + Math.Pow(yDistance, 2) + Math.Pow(zDistance, 2));
}

double xA, yA, xB, yB, zA, zB;
Console.Write("input x of point A: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("input y of point A: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("input x of point B: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("input y of point B: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("input y of point Z: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("input x of point Z: ");
zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(getDistance3D(xA, yA, xB, yB, zA, zB));

/*
//23:  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N

double getCubes(double num){
    num = Math.Abs(num);
    double index = num;
    double cubeNum = 0;
    while(num > 0 && index <= num){
        cubeNum = Math.Pow(num, 3);
        Console.WriteLine(cubeNum);
        num--;
        index--;
    }
    return cubeNum;
}

Console.WriteLine("enter your number ");
int number = Convert.ToInt32(Console.ReadLine());
getCubes(number);
*/

//19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int number;
int mirrorNumber = 0;
void mirror(int num5dg){
    int num;
    while(num > 0){

    }
}



 Console.WriteLine("enter 5digit number ");
 int number = Convert.ToInt32(Console.ReadLine());
 */