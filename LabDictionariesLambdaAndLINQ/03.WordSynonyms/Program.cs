int countWords = int.Parse(Console.ReadLine());

//срещу всяка дума -> списък със синоними
Dictionary<string, List<string>> wordSynosyms = new Dictionary<string, List<string>>();

for (int count = 1; count <= countWords; count++)
{
    string word = Console.ReadLine();
    string synosym = Console.ReadLine();

    if(!wordSynosyms.ContainsKey(word))//ако я нямаме в речника, добавяме като ключ, срещу нея празен списък
    {
        wordSynosyms.Add(word, new List<string>() {synosym});
    }
    else
    {
        //wordSynosyms.ContainsKey(word)
        wordSynosyms[word].Add(synosym); //добави синонима към вече срещаната дума
    }
}

//wordSynosyms
//записи
//Key: дума(string)
//value: списък със синоними String

foreach(KeyValuePair <string, List<string>> pair in wordSynosyms)
{
    //pair
    //pair.Key: дума(string)
    //pair.Value: списък със синоними List<string>
    string word = pair.Key;
    List<string> synosyms = pair.Value;

    Console.WriteLine(word + " - " + string.Join(", ", synosyms));
}