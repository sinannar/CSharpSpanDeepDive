int[] array = Enumerable.Range(0, 1000).ToArray();

while (true)
{
    // Copy first 50 of numbers to new array
    int[] copy = new int[50];
    Array.Copy(array, 0, copy, 0, 50);


    Sum(array);
}


static int Sum(int[] array, int offset, int length)
{
    int sum = 0;
    foreach (var i in array) sum += i;
    return sum;
}