string[] words = Console.ReadLine().Split().ToArray();// "Java C# PHP PHP JAVA C java"
                                                       // ["Java", "C#", "PHP", "PHP", "Java", "C", "java"]

//дума - брой срещания

Dictionary<string, int> wordsCount = new Dictionary<string, int>();

foreach (string word in words)
{
    string wordsWithLowerLetters = word.ToLower();//"JAVA" -> "java"
    if (!wordsCount.ContainsKey(wordsWithLowerLetters)) //ако не се съдържа
    {
        wordsCount.Add(wordsWithLowerLetters, 1);
    }
    else
    {
        wordsCount[wordsWithLowerLetters]++;
    }
}

//wordsCount 
foreach(KeyValuePair<string, int> pair in wordsCount)
{
    //pair - двойки
    //pair.Key - дума
    //pair.Value - бр. срещания
    
    if (pair.Value % 2 != 0)
    {
        Console.Write(pair.Key + " ");
    }
}