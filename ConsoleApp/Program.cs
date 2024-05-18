int[] array = new int[1000];

int[] three = [42, 43, 44];
Span<int> span = [42, 43, 44];
ReadOnlySpan<int> readonlyspan = [42, 43, 44];
three[0] = 45;
span[0] = 45;
//readonlyspan[0] = 45; // compile error

Sum(array);
Sum(new Span<int>(array, 0, 50));

unsafe
{
    int* ptr = stackalloc int[1000];
    Sum(new Span<int>(ptr, 1000));
}

static unsafe int Sum(Span<int> span)
{
    int sum = 0;
    foreach (int value in span) sum += value;
    return sum;
}