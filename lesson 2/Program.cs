
string AskInfo(string question, Func<string, bool> validator)
{
    Console.WriteLine($"Please, enter your {question}");
    var info = Console.ReadLine();
    if (validator(info))
    {
        return $"{question}: {info}\n";
    }
    else
    {
        Console.WriteLine("Please, enter the valid info");
        return AskInfo(question, validator);
    }
}

bool IsWord(string s)
{
    return s.All(Char.IsLetter);
}

bool IsNumber(string s)
{
    return !(!int.TryParse(s, out var number) || number > 100 || number < 1);
}

Console.WriteLine("\n" + AskInfo("name", IsWord) + AskInfo("surname", IsWord)
    + AskInfo("age", IsNumber) + AskInfo("hobby", IsWord));