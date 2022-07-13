int[] arr = {6, 8, 1, 4, 9, 2, 7};
int n = arr.Length;
int temp = 0;

for (int i = 0; i < n/2; i++)
{
    temp = arr[i];
    arr[i] = arr[n - i - 1];
    arr[n - i - 1] = temp;
    
}

for (int i = 0; i < n; i++)
{
    Console.Write(arr[i] + " ");
}
Console.WriteLine();

