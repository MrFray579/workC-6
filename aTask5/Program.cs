int[] arr = new int [5]{1, 2, 3, 4, 5};


int[] copyArray (int [] arr)
{
    int len = arr.Length;
    int[] copy = new int[len];

    for (int i = 0; i < len; i++)
    {
        copy[i] = arr[i];
        Console.Write(copy[i] + ", ");
    }
    Console.WriteLine();
    return copy;

}

int[] result = copyArray(arr);


