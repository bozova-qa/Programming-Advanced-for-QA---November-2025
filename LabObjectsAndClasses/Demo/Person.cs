//class Person - описваме всеки един човек, с който ще работим
//правила при наименуване на клас 
//1.EN
//2. PascalCase
//3. Съществителни имена


//Access Modifier - модификатори за достъп
//1. public - може да се достъпва навсякъде
//2. private - може да се достъпва в определени граници
class Person
{
    //характеристики -> име, възраст, тегло -> Properties
    //Properties се наименуват с главни букви
    //get - можем да достъпваме property и да виждаме неговата стойност
    //set - даваме възможност да задаваме стойност на нашето property
    public string Name { get; set; } //properties е стрингова променлива, която се казва Name
    public int Age { get; set; }
    public double Weight { get; set; }

    //конструктор - специален метод, чрез който създаваме обекти от класа
    //1.default конструктор - създава празен обект от класа

    public Person()
    {
        //нов празен обект от класа
        //Name =
        //Age =
        //Weght = 
    }

    //2.custom конструктор - създава обект от класа
    public Person(string name, int age, double weight)
    {
        //нов празен обект от класа
        //Name = "Ivan"
        //Age = 34
        //Weght = 87.5
        Name = name;
        Age = age;
        Weight = weight;
    }


    //действия -> яде, говори, спи -> Methods
    //public method - can be accessed from anywhere in your program; you need to call it
    //private method - accessible only inside the same class

    //static method -> използва се чрез Person.Eat() -> описваме действия, които са присъщи за класа
    //public void - трябва да създадем инстанция от класа и след това да го използваме
    public static void Eat()
    {
        Console.WriteLine("I am eating.");
    }

    private void Speak()
    {
        Console.WriteLine("I am speaking.");
    }

    public void Sleep()
    {
        Console.WriteLine("I am sleeping.");
    }
}
