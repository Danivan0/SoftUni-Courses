/*          Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p persons. The input holds two lines: the number of people n and 
the capacity p of the elevator.
Examples

Input   Output  Comments
17      6       5 courses * 3 people + 1 course * 2 persons
3

4       1       All the persons fit inside in the elevator. Only one course is needed.
5

10      2       2 courses * 5 people
5 

Hints
· You should divide n by p. This gives you the number of full courses (e.g. 17 / 3 = 5).
· If n does not divide p without a remainder, you will need one additional partially full course (e.g. 17 % 3 = 2).
· Another approach is to round up n / p to the nearest integer (ceiling), e.g. 17 / 3 = 5.67 -> rounds up to 6.
· Sample code for the round-up calculation:     int courses = (int)Math.Ceiling((double)n /p;            */

int peopleCount = int.Parse(Console.ReadLine());
int elevCapacity = int.Parse(Console.ReadLine());

if (peopleCount < elevCapacity)
{
    Console.WriteLine(1);
    
}

else 
{
    int courseCount = peopleCount / elevCapacity;

    if (peopleCount % elevCapacity != 0)
    {
        Console.WriteLine(courseCount + 1);
    }

    else
    {
        Console.WriteLine(courseCount);
    }
}