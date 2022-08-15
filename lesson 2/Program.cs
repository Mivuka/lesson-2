
string ask(string i)
{
    Console.WriteLine($"Please, enter your {i}");
    var info = Console.ReadLine();
    if (isWord(info))
    {
        return $"{i}: {info}\n";
    }
    else
    {
        Console.WriteLine("Please, enter the valid info");
        return ask(i);
    }

}

bool isWord(string s)
{
    foreach (char c in s)
    {
        if (!Char.IsLetter(c))
            return false;
    }
    return true;
}

string askAge(string i)
{
    Console.WriteLine($"Please, enter your {i}");
    var info = Console.ReadLine();
    if (isNumber(info))
    {
        return $"{i}: {info}\n";
    }
    else
    {
        Console.WriteLine("Please, enter the valid info");
        return askAge(i);
    }

}

bool isNumber(string s)
{
    foreach (char c in s)
    {
        if (!int.TryParse(s, out var number) || number > 100 || number < 1)
            return false;
    }
    return true;
}

Console.WriteLine("\n" + ask("name") + ask("surname") + askAge("age") + ask("hobby"));