//int[] array = new int[1000];

//int[] three = [42, 43, 44];

//// C# compiler generate UTF8 bytes from this string and blitting those directly to assembly and span just pointing to that data in binary
//ReadOnlySpan<byte> span = "Hello, Sinan"u8;


//string.Create(34, Guid.NewGuid(), (span, guid) =>
//{
//    "ID".AsSpan().CopyTo(span);
//    guid.TryFormat(span.Slice(2), out _, "N");
//});

////static string Create(Action<char[]> action)
////{

////}

////Create(array => { 
////    array[0] = 'H';
////    s_array = array;
////});
////char[] s_array;


//Sum(array);
//Sum(new Span<int>(array, 0, 50));

//unsafe
//{
//    int* ptr = stackalloc int[1000];
//    Sum(new Span<int>(ptr, 1000));
//}

//static unsafe int Sum(Span<int> span)
//{
//    int sum = 0;
//    foreach (int value in span) sum += value;
//    return sum;
//}



int i = 0;

Console.WriteLine(i);
Use(ref i);
Console.WriteLine(i);

static ref int  Use(ref int i)
{
    ref int j = ref i;
    return ref i;
}