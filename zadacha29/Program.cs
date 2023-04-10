void FillArray(int[] array, int minValue, int maxValue)
{
    int length = array.Length;
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minValue, maxValue + 1);
    }
}

int[] array = new int[8];
FillArray(array, 0, 10);
Console.Clear();
Console.WriteLine(string.Join(", ", array));