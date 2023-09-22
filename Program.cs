using System;

var index = 1;

while (index != 118)
{
    if (index % 10 == 4)
    {
        Console.WriteLine(index + 1);
        index = index + 2;
    }
    else if (index % 100 == 13)
    {
        Console.WriteLine(index + 2);
        index = index + 3;
    }
    else
    {
        Console.WriteLine(index);
        index = index + 1;
    }
}