/*
 The prime factors of 13195 are 5, 7, 13 and 29.

What is the largest prime factor of the number 600851475143 ?
*/

long number = 600851475143;
long dividing = 2;
long maxPrime = 0;

while (true)
{
    if (number% dividing != 0)
    {
        dividing = dividing + 1;
    }
    else
    {
        maxPrime = dividing;
        number = number/ dividing;
        if (number==1)
        {
            Console.WriteLine(maxPrime);
            break;
        }

    }
}