/*
 A palindromic number reads the same both ways. 
The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

Find the largest palindrome made from the product of two 3-digit numbers.
 */



int greatNumber = 0;

for (int i = 100; i < 1000; i++)
{
    for (int a = 100; a < 1000; a++)
    {
        int multiple = i * a;
        var multipleReverse= multiple.ToString().ToArray().Reverse();
        string multipleReverseString = "";
        foreach (var item in multipleReverse)
        {
            multipleReverseString += item;
        }

        if (multiple.ToString() == multipleReverseString && multiple> greatNumber)
        {
            greatNumber = i * a;
        }
    }
}

Console.WriteLine(greatNumber);

