using System.Data.Common;

//StringBuilder - идеята е вътре в него да констриураме текст; заделя буферно пространство;

//създаване на StringBuilder - 
using System.Text;
using System.Text;

StringBuilder sb = new StringBuilder();//създаване на празен StringBuilder
StringBuilder builderName = new StringBuilder("Nadezhda");//създаване на StringBuilder с текст

//добавяне на текст в StringBuilder
builderName.Append(" Bozova");//"Nadezhda Bozova"
builderName.AppendLine();//"Nadezhda Bozova\n" - поставя нов ред в текста
builderName.Append("Ivan Ivanov");

//дължина на Stringbuilder-a
int count = builderName.Length;//колко е броят на символите в текста в стрингбилдер-а
Console.WriteLine(builderName.Length);

//изтриване StringBuilder
builderName.Clear();//премахва всички символи в текста-> ""

//достъпване на символ в StringBuilder
sb.Append("Cat Tom");//"вече текстът, който се съхранява в sb ще бъде Cat Tom
Console.WriteLine(sb[0]);//'C'
Console.WriteLine(sb[sb.Length - 1]);//'m'

//вмъкване на текст/ символ в StringBuilder
sb.Insert(0, "Ivan");//"IvanCat Tom"
sb.Insert(0, 'R');//"RIvanCat Tom"

//Replace - замяна на текст
//Replace(string oldValue, string newValue);
sb.Replace("Cat", "Dog");//"RIvanDog Tom"

//преобразуване на StringBuilder в String
string text = sb.ToString();//"RIvanDog Tom"

//Преобразуване на String в StringBuilder
string name = "Ana Ivanova";
StringBuilder nameBuilder = new StringBuilder(name);

