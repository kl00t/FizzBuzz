int iterations = 100;
for (int i = 1; i < iterations; i++)
{
    var output = string.Empty;

    if (i % 3 == 0)
    {
        output += "Fizz";
    }
    if (i % 5 == 0)
    {
        output += "Buzz";
    }

    if (output == string.Empty)
    {
        output = i.ToString();
    }

    Console.WriteLine(output);
}