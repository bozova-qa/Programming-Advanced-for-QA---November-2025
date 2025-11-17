//ученик-оценка

//създаване на нов празен речник
using System.Collections.Generic;
using System.Linq;

Dictionary<string, double> studentGrades = new Dictionary<string, double>();
Dictionary<string, double> studentQuotes = new ();

//добавяне на записи в речник
//начин 1
studentGrades.Add("Alex", 5.60);//в този ред, защото предварително сме дефинирали типовете на записите
studentGrades.Add("Alex", 4.50); // не можем да добавяме два пъти на един и същи ключ
                                // 
//начин 2
studentGrades["Ivan"] = 4.30;//срещу key Ivan става 4.30

// създаване на речник с предварително дефинирани записи
Dictionary<string, int> fruits = new()
{
    {"Kiwi", 3 },
    { "Apple", 5}
};

// премахване на записи от речник
fruits.Remove("Kiwi");// премахва целия запис
studentGrades.Remove("Alex");

//размер на речник == брой на записите, които са съхранени в него
int countPair = studentGrades.Count();
Console.WriteLine(fruits.Count);//1

//премахване на всички записи
fruits.Clear();
Console.WriteLine(fruits.Count);//0

//проверка дали даден ключ/ стойност съществуват в речника
Dictionary<string, int> peopleAge = new Dictionary<string, int>();
peopleAge.Add("Nade", 38);
peopleAge.Add("Ivan", 40);
peopleAge.Add("Grigor", 40);
if (peopleAge.ContainsKey("Grigor"))
{
    Console.WriteLine("Grigor is on the list.");
}
bool isContains = peopleAge.ContainsKey("Ivana");//false

bool isAgeAvailable = peopleAge.ContainsValue(38);

//достъпваме value спрямо key
Console.WriteLine(peopleAge["Nade"]);//38
int age = peopleAge["Nade"];//38

//промяна на Value спрямо key

peopleAge["Ivan"] = 54;

//обхождане на речник == преминаване през всеки запис на речника
foreach(KeyValuePair<string, int> fruit in fruits)
{
    Console.WriteLine(fruit.Key + "->" + fruit.Value); // Kiwi - 3
}

//Sorted Dictionary == речник, при който записите се запазват в нарастващ ред спрямо ключа

//всички фунционалности горе се отнасят и за sorteddictionary
SortedDictionary<string, double> productPrices = new SortedDictionary<string, double>();//празен речник
SortedDictionary<string, double> productPrice = new();
productPrices.Add("tomato", 4.50);
productPrices.Add("Bread", 2.30);
productPrices.Add("Apple", 3.40);
productPrices.Add("Milk", 1.20);
//Apple->3.40
//Bread->2.30
//Milk->1.20
//Tomato->4.50