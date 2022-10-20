// See https://aka.ms/new-console-template for more information
Console.WriteLine("Start");
for (long i = 0; i <= long.MaxValue; i++)
{
    var length = i.ToString().Length;
    long result = 0;
    foreach (var valueChar in i.ToString())
    {
        var value = long.Parse(valueChar.ToString());
        result = (long)(result + Math.Pow(value, length));
    }
    if (i == result)
    {
        Console.WriteLine("Find:" + i.ToString());
    }
}
Console.WriteLine("End");