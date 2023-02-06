// Function calculates the multiplication of numbers in range [1,N]

int multDigits(int num)
{
    int mult = 1;
    for (int i = 2; i <= num; i++) mult = mult * i;
    return mult;
}

int num = 0;

while (num < 1)
{
    Console.Write("Enter a positive integer number: ");
    num = int.Parse(Console.ReadLine());
}

Console.WriteLine($"The multiplication of numbers in range [1,{num}] is {multDigits(num)}.");

