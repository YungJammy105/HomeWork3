Console.Write("Enter the length of the array: ");
int countDigit = int.Parse(Console.ReadLine());
Console.Write("Enter the power of the array: ");
int powerDigit = int.Parse(Console.ReadLine());
int[] arrayPower = new int[countDigit];

PrintArray(FillArrayPower(arrayPower, countDigit, powerDigit));

int[] FillArrayPower(int[] coll, int num, int pow)
{
    int firstDigit = 1;
    int index = 0;
    while(index < coll.Length)
    {
        coll[index] = PowerOfNumber(firstDigit,pow);
        firstDigit++;
        index++;
    }
    return coll;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int PowerOfNumber(int number, int power)
{
    int result = number;
    for(int i = 1; i < power; i++)
    {
        
        result = result * number;
    }
    return result;
}
