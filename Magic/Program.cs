﻿// оператор цикла while
Console.Clear(); // очистка консоли
Console.SetCursorPosition(10, 4); // отступы первая величина - отступ слева, вторая - сверху (строки)
Console.WriteLine("+"); // вывод точки в виде знака плюс по отступам

int xa = 10;
int ya = 1;
int xb = 50;
int yb = 10;
int xc = 80;
int yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = ya;
int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); // случайное число в интервале от 0 до 3, то есть 0, 1, 2
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // или count +=1, или count++
}