using System.Diagnostics.SymbolStore;

string text = Console.ReadLine(); //"text text text"

Dictionary<char, int> countChars = new Dictionary<char, int>();

foreach(char symbol in text)
{
    if (symbol == ' ')
    {
        continue;
    }
    if (!countChars.ContainsKey(symbol)) //ако го няма, значи го срещаме за 1 път и трябва да го добавим
    {
        countChars.Add(symbol, 1);
    }
    else
    {
        //вече сме срещали, просто увеличаваме
        countChars[symbol]++;
    }
}

foreach(KeyValuePair <char, int> pair in countChars)
{
    //pair - всеки запис от речника
    //pair.Key
    //pair.Value - сумарното срещане
    Console.WriteLine(pair.Key + " -> " + pair.Value);
}
