string[] words = Console.ReadLine().Split().ToArray();
//string[] words = Console.ReadLine().Split().Where(word => word.Length % 2 == 0).ToArray();
Dictionary<string, int> wordsWithEvenLength = new Dictionary<string, int>();

foreach(string word in words)
{
    if (word.Length % 2 == 0)
    {
        wordsWithEvenLength.Add(word, 1);
    }
}

foreach(KeyValuePair<string, int> pair in wordsWithEvenLength)
{
    Console.WriteLine(pair.Key);
}

