using System.Text;

string input = Console.ReadLine();

StringBuilder sbDigits = new StringBuilder();

StringBuilder sbLetters = new StringBuilder();

StringBuilder sbSymbols = new StringBuilder();

foreach(char symbol in input)
{
    //проверка за вида на символа
    if (char.IsDigit(symbol))
    {
        sbDigits.Append(symbol);
    }
    else if (char.IsLetter(symbol))
    {
        sbLetters.Append(symbol);
    }
    else
    {
        sbSymbols.Append(symbol);
    }
}

Console.WriteLine(sbDigits.ToString());
Console.WriteLine(sbLetters.ToString());
Console.WriteLine(sbSymbols.ToString());

