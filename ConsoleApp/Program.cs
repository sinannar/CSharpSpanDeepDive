int[] array = new int[1000];

int[] three = [42, 43, 44];

// C# compiler generate UTF8 bytes from this string and blitting those directly to assembly and span just pointing to that data in binary
ReadOnlySpan<byte> span = "Hello, Sinan"u8; 

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