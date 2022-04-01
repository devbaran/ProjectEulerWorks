/*
 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
 */


int smallest = 0;
int x = 0;
while (x>=0)
{
    x += 20;
    int tempSmall = 0;
    int tempCount = 0;

   
    for (int i = 1; i < 21; i++)
    {

        if (x % i == 0)
        {
            tempCount++;
            tempSmall = x;


        }
        else
        {
            break;
        }

    }

    if (tempCount == 20)
    {
        smallest = tempSmall;
        break;

    }



}
Console.WriteLine(smallest);