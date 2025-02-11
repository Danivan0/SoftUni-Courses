/*          Create a program, which sums the ASCII codes of n characters and prints the sum on the console.

Input
· On the first line, you will receive n – the number of lines, which will follow.
· On the next n lines – you will receive letters from the Latin alphabet.

Output
Print the total sum in the following format:
"The sum equals: {totalSum}"

Constraints
· n will be in the interval [0…20].
· The characters will always be either upper or lower-case letters from the English alphabet.
· You will always receive one letter per line.                                      */


int n = int.Parse(Console.ReadLine());

int totalSum = 0;

for (int i = 0; i < n; i++)
{
   
    char letter = char.Parse(Console.ReadLine()); 
    totalSum += (int)letter; 
}

// Output the total sum
Console.WriteLine($"The sum equals: {totalSum}");