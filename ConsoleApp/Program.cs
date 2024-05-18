int[] array = Enumerable.Range(0, 1000).ToArray();

while (true)
{
    Sum(array, 0 , 50);
}


static int Sum(int[] array, int offset, int length)
{
    int sum = 0;
    for (int i = offset; i < offset + length; i++)
    {
        sum += array[i];
    }
    return sum;
}