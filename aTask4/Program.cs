void Fibonacci(int n)
{
    int fib1 = 0;
    int fib2 = 1;
    int sum = 0;

    if(n >= 1)
    Console.WriteLine(fib1);

    if(n >= 2)
    Console.WriteLine(fib2);

    int i = 0;
    while (i < n - 2)
    {
        sum = fib1 + fib2;
        Console.WriteLine(sum);
        fib1 = fib2;
        fib2 = sum;
        i++;
    }
}

int N = 7;
Fibonacci(N);