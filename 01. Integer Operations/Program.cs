/*          Create a program that receives four integer numbers.
You should perform the following operations:
· Add first to the second.
· Divide (integer) the result of the first operation by the third number.
· Multiply the result of the second operation by the fourth number.

Print the result after the last operation.
Constraints
· First number will be in the range [-2,147,483,648…2,147,483,647].
· Second number will be in the range [-2,147,483,648…2,147,483,647].
· Third number will be in the range [-2,147,483,648…2,147,483,647].
· Fourth number will be in the range [-2,147,483,648…2,147,483,647].

Examples
Input   Output          Input   Output
10      30              15      42
20                      14 
3                       2
3                       3                                           */


int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
int num4 = int.Parse(Console.ReadLine());
int num5 = int.Parse(Console.ReadLine());

int first = num1 + num2;
int second = first / num3;
int third = second * num4;

Console.WriteLine(third);



