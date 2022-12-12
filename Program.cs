/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int CutNumber(int num)
{
    int des = num % 100;
    //int ed = num % 10;

    int result = des / 10;// - ed;
    return result;
}

int randNum = new Random().Next(100, 1000);
int newNum = CutNumber(randNum);

Console.WriteLine($"New version of a number {randNum} is {newNum}");*/

// Павел, нужна ли переменная "int ed" Или как я понимаю, только для более точных вычислений, так как десятичный остаток получается.//  

