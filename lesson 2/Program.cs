using System.Text;

var description = new Dictionary<string, string>()
{
    ["name"] = "This field may contain only letters",
    ["surname"] = "This field may contain only letters",
    ["age"] = "This field may contain only number in the range from 1 to 100",
    ["hobby"] = "This field may contain only letters",
};

var answer = new StringBuilder();

string AskInfo(string question, Func<string, bool> validator)
{
    var info = Console.ReadLine();
    if (validator(info))
    {
        return $"Your {question}: {info}\n";
    }
    else
    {
        Console.WriteLine("Please, enter the valid info. " + description[question]);
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
Console.WriteLine("Please, enter your name");
answer.Append(AskInfo("name", IsWord));
Console.WriteLine("Please, enter your surname");
answer.Append(AskInfo("surname", IsWord));
Console.WriteLine("Please, enter your age");
answer.Append(AskInfo("age", IsNumber));
Console.WriteLine("Please, enter your hobby");
answer.Append(AskInfo("hobby", IsWord));

Console.WriteLine("\n" + answer.ToString());

