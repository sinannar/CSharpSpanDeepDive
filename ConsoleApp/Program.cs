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

unsafe
{
    int* ptr = &i;
    ref int iref = ref *ptr;

    // we have managerd reference for pointer value
    // we can use USE function that we defined below with that managed refernce as iref
    // if we have that reference and length as tuple, that is Span itself actually
    // put this ref and legnth as tuple and pass around, so ref should be able to use as a field

}

static void Use(ref int reference, int length)
{

}