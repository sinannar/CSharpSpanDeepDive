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



//int i = 0;

//unsafe
//{
//    int* ptr = &i;
//    ref int iref = ref *ptr;

//    // we have managerd reference for pointer value
//    // we can use USE function that we defined below with that managed refernce as iref
//    // if we have that reference and length as tuple, that is Span itself actually
//    // put this ref and legnth as tuple and pass around, so ref should be able to use as a field

//}

//static void Use(ref int reference, int length)
//{

//}

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

int i = 42;
Console.WriteLine(i);
var span = new MySpan<int>(ref i, 1000);
span[0] = 43;
Console.WriteLine(i);

readonly ref struct MySpan<T>
{
    private readonly ref T _reference; // ref field can only be declared in a ref struct
    private readonly int _lenght;

    public MySpan(ref T reference)
    {
        _reference = ref reference;
        _lenght = 1;
    }

    public MySpan(T[] array)
    {
        ArgumentNullException.ThrowIfNull(array, nameof(array));
        //_reference = ref array[0];
        _reference = ref MemoryMarshal.GetArrayDataReference(array);
        _lenght = array.Length;
    }

    // This does not exist on Span, it exist on MemoryMarshal.CreateSpan
    public MySpan(ref T reference, int lenght) // MemoryMarshal.CreateSpan
    {
        _reference = ref reference;
        _lenght = lenght;
    }

    public ref T this[int index]
    {
        get
        {
            if ((uint)index >= (uint)_lenght)
            {
                throw new IndexOutOfRangeException();
            }
            return ref Unsafe.Add(ref _reference, index); // using ref here remove the necessity of writing Setter for this piece
        }
    }

    //public T this[int index]
    //{
    //    get
    //    {
    //        if ((uint)index >= (uint)_lenght)
    //        {
    //            throw new IndexOutOfRangeException();
    //        }
    //        return Unsafe.Add(ref _reference, index); 
    //    }

    //    set
    //    {
    //        if ((uint)index >= (uint)_lenght)
    //        {
    //            throw new IndexOutOfRangeException();
    //        }
    //        Unsafe.Add(ref _reference, index) = value;
    //    }
    //}
}



