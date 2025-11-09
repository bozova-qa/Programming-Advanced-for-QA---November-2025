string[] words = Console.ReadLine().Split(" ").ToArray();//"hi abc add" -> ["hi", "abc", "add"];

foreach (string word in words)
{
    int length = word.Length;
    for (int count = 1; count <= length; count++)//повтаря действието толкова пъти, колкото е дължината
    {
        Console.Write(word);
    }
}



