// Print a 8-dimension random array with 0 ad 1.

int[] arr1 = new int[8];
int[] arr2 = new int[8];
int[] arr3 = new int[8];

arr1 = randomArray();
printArray(arr1);

arr2 = randomArray();
printArray(arr2);

arr3 = sumArr(arr1, arr2);
printArray(arr3);

int[] randomArray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
        array[i] = new Random().Next(0, 2);
    return array;
}

int[] sumArr(int[] array1, int[] array2)
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
        array[i] = array1[i] + array2[i];
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < 8; i++)
        Console.Write(array[i] + ", ");
    Console.WriteLine();
}