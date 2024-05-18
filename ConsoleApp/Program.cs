int[] array = new int[1000];

// unsafe is disabling JIT bound check
unsafe
{
    fixed (int* ptr = array)
    {

    }
}

static unsafe int Sum(int* pointer, int length)
{
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += pointer[i];
    }
    return sum;
}