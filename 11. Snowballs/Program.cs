﻿/*          Tony and Andi love playing in the snow and having snowball fights, but they always argue about which makes the best snowballs. They have decided to involve you in their 
fray by making you write a program, which calculates snowball data and outputs the best snowball value.

You will receive N – an integer, the number of snowballs being made by Tony and Andi. For each snowball you will receive 3 input lines:
· On the first line, you will get the snowballSnow – an integer.
· On the second line you will get the snowballTime – an integer.
· On the third line, you will get the snowballQuality – an integer.

For each snowball you must calculate its snowballValue by the following formula:
(snowballSnow / snowballTime) ^ snowballQuality

In the end, you must print the highest calculated snowballValue.

Input
· On the first input line, you will receive N – the number of snowballs.
· On the next N * 3 input lines, you will be receiving data about snowballs.

Output
· As output, you must print the highest calculated snowballValue, by the formula, specified above.
· The output format is: {snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})

Constraints
· The number of snowballs (N) will be an integer in the range [0…100].
· The snowballSnow is an integer in the range [0…1000].
· The snowballTime is an integer in the range [1…500].
· The snowballQuality is an integer in the range [0…100].
· Allowed working time/memory: 100ms / 16MB.                                        */

using System.Numerics;

int ballsCount = int.Parse(Console.ReadLine());         //n

int maxSnow = 0;
int maxTime = 0;
int maxQuality = 0;
BigInteger maxValue = 0; 

for (int i = 1; i <= ballsCount; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger divide = new BigInteger(snowballSnow / (double)snowballTime);
    BigInteger snowballValue = BigInteger.Pow(divide, snowballQuality);

    if (snowballValue > maxValue)
    {
        maxValue = snowballValue;
        maxQuality = snowballQuality;
        maxTime = snowballTime;
        maxSnow = snowballSnow;
    }


}

Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
