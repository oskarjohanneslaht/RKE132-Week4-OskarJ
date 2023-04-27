

int sum = 0;

for (int i = 10; i > 0; i--)
{
    
    Console.WriteLine($"i = {i + 1}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i;
}

Console.WriteLine(sum);
 