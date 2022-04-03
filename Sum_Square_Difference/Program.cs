/*
 The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2=385

The square of the sum of the first ten natural numbers is, (1+2+3+ ... +10)^2 = 55^2 = 3025

Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is .
3025 - 385 = 2640

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
 */

var numberList = Enumerable.Range(1,100).ToList();

int squareOfSum = 0;
foreach (var a in numberList)
{
    squareOfSum += a * a;
}

int sumOfHundered = 0;
foreach (var a in numberList)
{
    sumOfHundered += a;
}

var squareOfSumOfHundered = sumOfHundered * sumOfHundered;
var result = squareOfSumOfHundered - squareOfSum;

Console.WriteLine(result);