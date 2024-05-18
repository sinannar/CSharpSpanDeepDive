var array = Enumerable.Range(0, 1000).ToArray();
var list = Enumerable.Range(0, 1000).ToList();

while (true)
{
    SumA(array, 0 , 50);
    SumL(list, 0 , 50);
}


static int SumA(int[] array, int offset, int length)
{
    int sum = 0;
    for (int i = offset; i < offset + length; i++)
    {
        sum += array[i];
    }
    return sum;
}

static int SumL(List<int> array, int offset, int length)
{
    int sum = 0;
    for (int i = offset; i < offset + length; i++)
    {
        sum += array[i];
    }
    return sum;
}