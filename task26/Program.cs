// Write a function which counts the number of digits in a number

int countDigits(int num)
{
    int count = 1;
    int curNum = Math.Abs(num);
    while (curNum > 9)
    {
        curNum = curNum / 10;
        count++;
    }
    return count;
}

Console.Write("Enter an integer number: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"The number of digits in number {num} is {countDigits(num)}.");


