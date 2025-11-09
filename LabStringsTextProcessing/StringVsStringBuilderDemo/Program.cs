//StringBuilder е по-бърз от string, защото предварително заделя някакво буферно пространство

//бързината на конкатенацията със String
/*string text = "";
for (int i = 0; i < 20000; i++)
{
    //20000  пъти операцията се конкатенира
    text += i;
}

Console.WriteLine(text);*/

//Бързина на конкатенация със StringBuilder -> много по-бърз заради буферното пространство, което
//създава предварително

using System.Text;

StringBuilder text = new StringBuilder();//""
for (int i = 0; i < 20000; i++)
{
    //20000  пъти операцията се конкатенира
    text.Append(i);
}
Console.WriteLine("Stop");