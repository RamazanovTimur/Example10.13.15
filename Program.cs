//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(int num)
{
    int des = num % 100;

    int result = des / 10;
    return result;
}

Console.WriteLine("Введите трехзначное число:");
int userNum = Convert.ToInt32(Console.ReadLine());

if (userNum >= 100 && userNum <1000)
{
    int newNum = CutNumber(userNum);
    Console.WriteLine($"Second number is {newNum}");
}
else
{
    Console.WriteLine("Не верно указано трехзначное число. Попробуйте еще раз");
}

/*// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());

int thirdNum = num;

while (thirdNum >= 999)
{
    thirdNum = thirdNum / 10;
    Console.WriteLine(thirdNum);
}
 
thirdNum = thirdNum % 10;
Console.WriteLine(thirdNum);
//Console.WriteLine(thirdNum);*/