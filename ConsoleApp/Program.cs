int[] array = Enumerable.Range(0, 1000).ToArray();

while (true)
{
    int[] copy = new int[50];
    Array.Copy(array, 0, copy, 0, 50);
    Sum(copy);
}


static int Sum(int[] array)
{
    int sum = 0;
    foreach (var i in array) sum += i;
    return sum;
}