int num = 12;
int t = 0, d = 1;
int i = 0;

    while (i < num)
    {
        t += (num % 2) * d;
        num = num/2;
        d = d * 10;
    }

Console.WriteLine(t);