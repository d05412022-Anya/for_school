//В первой задаче вам можно было просто исходное число разделить нацело на 10(456 / 10-> 45), 
//а затем найти остаток от деления на 10(45 % 10 -> 5) и получится верный ответ :) не придётся делать массу лишних операций,
//хотя ваш вариант также дает верный результат! 
//Во второй задаче аналогично, всё решается через использование только деления и находжения остатков. 
//И я так и не смог понять, что у вас делает переменная helpNum. 
//В последней задаче есть маленькая ошибка в 28 строке (day < 8. Там необходимо перевернуть знак <)


//1:
void ShowSecond(int num){
    int part1 = num / 100; 
    int part2 = part1 % 10; 
    Console.WriteLine(part2);
    }
Console.WriteLine("enter 3digit number");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"the second digit of this number is ");
ShowSecond(num);
/*
2:
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
    } //helpNum сокращает число до 3 цифр через деление и счётчик (ставила +10 сначала, но это много, 9 вот не пробовала),
    //я не смогла разобраться, как ещё сократить до 3х цифр именно
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


void Days(int day){
if(day < 6){//это для будних
            Console.Write("nope");
        }
    if(day > 5 && day < 8){
            Console.Write("yep");
        }
    if(day > 7){   //это для тех чисел, что не входят в нужные
        Console.Write("just a number");
    }
}
Console.Write("What day is it?");
int day = Convert.ToInt32(Console.ReadLine());
Days(day);

*/