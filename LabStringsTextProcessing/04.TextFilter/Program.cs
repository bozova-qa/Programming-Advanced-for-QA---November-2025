string[] banList = Console.ReadLine().Split(", ").ToArray(); //["Linux", "Windows"] 
string text = Console.ReadLine();

foreach (string ban in banList)
{
   
    string replacement = new string('*', ban.Length);
    //създаваме нов стринг, където * се повтаря толкова пъти, колкото е дължината на думата 
    //ban = "Linux" -> "*****"

    text = text.Replace(ban, replacement);
}
Console.WriteLine(text);