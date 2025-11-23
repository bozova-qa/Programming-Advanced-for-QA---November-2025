//class Program - използваме, за да създаваме обекти и да пишем програмна логика

//създаваме обект от класа Person чрез default конструктор

Person personDesi = new Person(); //нов празен обект от класа Person

//personDesi - ще има всички харектеристики по-долу
//Name = 
//Age = 
//Weight = 
//Eat, Sleep, Speak


//задаване стойност на property -> случва се благодарение на set
personDesi.Name = "Desislava";
personDesi.Age = 27;
personDesi.Weight = 60;
//Name = Desislava
//Age = 27
//Weight = 60 
//Eat, Sleep, Speak

//достъпвате стойност на property -> случва се благодарение на get; ако няма get, не можем да достъпим
Console.WriteLine(personDesi.Name);//"Desislava"
Console.WriteLine(personDesi.Age);//27
Console.WriteLine(personDesi.Age);//60

//достъпване на действия/ методи
personDesi.Sleep(); //можем само този да достъпим, защото е публичен
//personDesi.Speak(); -> не можем да достъпваме private methods от класа
Person.Eat(); //достъпване на статичен метод


//създаваме обект от класа Person чрез custom конструктор
Person personIvan = new Person("Ivan", 34, 87.5); //нов празен обект
//Name = "Ivan"
//Age = 34
//Weight = 87.5 
personIvan.Name = "Petar";
personIvan.Age = 27;
//personIvan
//Name = "Petar"
//Age = 34
//Weight = 87.5 

