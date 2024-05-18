var list = Enumerable.Range(0, 1000).ToList();

while (true)
{
    Sum(list, 0 , 50);
}

unsafe
{ 
    int* pointer = stackalloc int[1000];
    int length = 1000;
    Sum(pointer, 0, length);
}

static int Sum(IList<int> array, int offset, int length)
{
    int sum = 0;
    for (int i = offset; i < offset + length; i++)
    {
        sum += array[i];
    }
    return sum;
}

