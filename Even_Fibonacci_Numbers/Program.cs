List<int> numbers = new List<int>();

numbers.Add(1);
numbers.Add(2);

while (numbers.Last() < 4000000)
{
    int last = numbers.Count();
    numbers.Add(numbers[last-2]+numbers[last-1]);
    
}
int sum = 0;
foreach (var item in numbers)
{
    if (item%2==0 && item<4000000)
    {
        sum=sum+item;
    }
}
Console.WriteLine(sum);