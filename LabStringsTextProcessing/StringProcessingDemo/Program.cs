//string - съвкупност от символи/ масив от символи

using System.Linq.Expressions;

string name = "Nade";
char[] letters = name.ToCharArray(); //['N', 'a', 'd', 'e']
string firstName = letters.ToString();// ['N', 'a', 'd', 'e'] -> "Nade"

//дължина на текст == броя на символите в текста
int length = firstName.Length;//4, можем да я съхраняваме в променлива
Console.WriteLine(name.Length);//4

//въвеждане на текст от комзолата
string text = Console.ReadLine();

//конкатенация - долепяне на текстове
//"Наде" "Иван"-> "НадеИван"
//1.начин +
string animal = "dog";
string food = "meat";
string concatenatedString = animal + food;
//string + string = string
Console.WriteLine(animal + food);//"dogmeat"

//string + int = string
int number = 4;
Console.WriteLine(animal + number);//"dog4"

//string + double 
double num = 4.5;
Console.WriteLine(animal + num);//"dog4.5"

//string + char = string
char letter = 'R';
Console.WriteLine(animal + letter);//"dogR"

//2.начин - concat
string dogFood = string.Concat(animal, food); //в скобите това, което искаме да долепим, "dogmeat"
Console.WriteLine(string.Concat(animal, food));

//Split на текст
string sentence = "I am Nadezhda from Plovdiv";
string[] words = sentence.Split(" ");//["I", "am", "Nadezhda", "from", "Plovdiv"]
string wordsInOrder = "turtle, mouse, cat, dog";
string[] animals = wordsInOrder.Split(", ");// ["turtle", "mouse", "cat", "dog"]

//Join на текст
string textExample = string.Join("-", "con", "ca", "ten", "ate");//"con-ca-ten-ate"
string fullText = string.Join("", "Des", "isla", "va");//Desislava, съединява без интервал
string[] names = new string[3] { "Ivan", "Georgi", "Sasho" };
string result = string.Join(", ", names);// "Ivan, Georgi, Pesho"

//Търсене в текст
string input = "I am 38 years old.";

bool isContains = input.Contains('o');//true
input.Contains("years");//true
bool isRobot = input.Contains("robot");//false

//IndexOf() - първото срещане на текста
string fruits = "banana, apple, kiwi, banana, apple";
Console.WriteLine(fruits.IndexOf("banana"));//0 -> отпечатва първия индекс, на който се среща
Console.WriteLine(fruits.IndexOf("orange"));//-1

//LastIndexOf() - последното срещане на текста

string fruit = "banana, apple, kiwi, banana, apple";
Console.WriteLine(fruits.LastIndexOf("banana"));//21 -> отпечатва последния индекс, на който се среща, 21 е индексът на последното "а" от banana
Console.WriteLine(fruits.IndexOf("orange"));//-1 -> даденият индекс не е намерен

//достъпване на символ в текст
string robotName = "Jasper";
Console.WriteLine(robotName[0]);//първият символ в текста 'J'
Console.WriteLine(robotName[robotName.Length - 1]);//последният символ в текста
char symbol = robotName[2];

//Replacing - замяна на текст
string vegetables = "tomato, cucumber, carrot, pepper, tomato";
vegetables = vegetables.Replace("tomato", "onions");//onions, cucumber, carrot, pepper, onions
//презаписваме променливата, защото не можем да я обработим вътре в нея

//Substring на текст - to extract a substring from a string that begins at a specified character
//position and ends at the end of the string
string bookName = "Harry Potter";
//начин 1:
string firstPart = bookName.Substring(0, 5);//"Harry", позицията, на която приключва, не се включва
                                            //т.е. интервалът

//начин 2:
string secondPart = bookName.Substring(6);//взима текста от 6 позиция до края, "Potter"

//обхождане на текст -> преминаване пред всеки един от символите му
string concert = "Concert in o2 arena.";
//1.начин - for loop
for (int position = 0; position < concert.Length - 1;position++)
{
    char currentSymbol = concert[position];
    Console.WriteLine(currentSymbol);
}

//2. начин - foreach loop
foreach (char ch in concert)
{
    Console.WriteLine(ch);
}

//Премахване на символи от текст
string tournament = "Wimbledon";
tournament = tournament.Remove(1, 3);//"Wledon"


