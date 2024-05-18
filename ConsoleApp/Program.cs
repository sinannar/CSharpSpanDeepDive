var list = Enumerable.Range(0, 1000).ToList();

while (true)
{
    Sum(list, 0 , 50);
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