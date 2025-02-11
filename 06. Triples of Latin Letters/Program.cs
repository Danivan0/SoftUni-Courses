/*          Create a program that receives an integer n and print all triples of the first n small Latin letters, ordered alphabetically            */

int n = int.Parse(Console.ReadLine());


for (char first = 'a'; first < 'a' + n; first++)
{
    for (char second = 'a'; second < 'a' + n; second++)
    {
        for (char third = 'a'; third < 'a' + n; third++)
        {
            Console.WriteLine($"{first}{second}{third}");
        }
    }
}