Console.Clear();
Console.WriteLine("Example 19!");
Thread.Sleep(1000);
Console.Clear();
Console.Write("Loading");
Thread.Sleep(600);
Console.Write(".");
Thread.Sleep(600);
Console.Write(".");
Thread.Sleep(600);
Console.Write(".");
Thread.Sleep(1700);
Console.Clear();
Console.Write("Enter number: ");
bool Int = int.TryParse(Console.ReadLine(), out int num);
int[] array = new int [CountDigit(num)];

if(ItIsPalindrome(FromNumberToArray(array, num)))
{
    Console.WriteLine("This number is a palindrome");
}
else
{
    Console.WriteLine("This number is not a palindrome");
}

bool ItIsPalindrome (int[] col)
{
    int position = 0;
    while(position < col.Length)
    {
        if(!(col[position] == (col[(col.Length-1)-position]))) return false;
        position++;
    }
    return true;
}

int[] FromNumberToArray(int[] arr, int digit)
{
    int index = arr.Length-1;
    int[] array = arr;
    while(index >= 0)
    {
        array[index] = digit % 10;
        digit = digit / 10;
        index--;
    }
    return array;
}

int CountDigit(int number)
{
    int i = 0;
    while (number > 0)
    {
        number = number / 10;
        i++;
    }
    return i;
}
