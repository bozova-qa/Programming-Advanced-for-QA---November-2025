string wordToRemove = Console.ReadLine();
string sentence = Console.ReadLine();

//повтаряме - премахваме думата от изречението
//while loop -з. не знаем колко пъти
//стоп - в secondString не се съдържа firstString
//продължаваме - в secoondString се съдържа firstString

while (sentence.Contains(wordToRemove))
{
    int positionWord = sentence.IndexOf(wordToRemove);//първия индекс, на който се среща
    sentence = sentence.Remove(positionWord, wordToRemove.Length);//премахваме от първата
    //позиция, на която се среща до дължината на думата;
}
Console.WriteLine(sentence);