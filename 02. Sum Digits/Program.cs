/*          Create a program that receives a single integer. Your task is to find the sum of its digits.
For example: 12345 → 1 + 2 + 3 + 4 + 5 = 15

Examples
Input       Output
245678      32
97561       28
543         12                                              */

int number = int.Parse(Console.ReadLine());

int sum = 0;

while (number > 0)
{
    sum += number % 10;
    number /= 10;
}

Console.WriteLine(sum);