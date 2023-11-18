
int numb;
Console.Write("Please enter integer value: ");
bool is_parsed = Int32.TryParse(Console.ReadLine(), out numb);

if (is_parsed)
{
    int sum = 0;
    
    for (int i = 1; i <= numb; i++)
    {
        sum += i;
    }
    Console.WriteLine($"the sum of the numbers from 1 to {numb} is: {sum} ");
}

else {
    Console.WriteLine("Invalid value");
}