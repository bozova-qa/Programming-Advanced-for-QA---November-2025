List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

SortedDictionary<int, int> countOccurences = new SortedDictionary<int, int>();

foreach(int number in numbers)
{
    if(countOccurences.ContainsKey(number))
    {
        countOccurences[number]++;
        //срещали сме числото
    }
    else
    {
        //не сме срещали числото
        countOccurences.Add(number, 1);//1, защото се среща за първи път
    }
}

//Dictionary - Key(число) -> Value(повтаряне)

foreach (KeyValuePair<int, int> pair in countOccurences)
{
    //pair
    //pair.Key -> число
    //pair.Value -> бр. срещания
    
    Console.WriteLine(pair.Key + " -> " + pair.Value);
}