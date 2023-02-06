// Program takes the positive integer number as input and gives the sum of numbers in range [1,N]

int sumNums(int num)
{
    int i = 1;
    int sum = 0;
    for (i = 0; i <= num; i++) sum += i;
    return sum;
}

int num = 0;
while (num < 1)
{
    Console.Write("Enter the positive integer number: ");
    num = int.Parse(Console.ReadLine());
}

int sum = sumNums(num);

Console.WriteLine($"The sum of number in range [1,{num}] is {sum}.");

