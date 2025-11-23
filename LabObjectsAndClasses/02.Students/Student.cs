public class Student
    {
    //описваме как изглежда всеки един студент

    //характеристики - чрез properties
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Age { get; set; }
    public string HomeTown { get; set; }

    //конструктор - специален метод за създаване на обекти
    public Student(string firstName, string lastName, int age, string homeTown)
    {
        //създаваме нов празен обект с текстова променлива, която ще задаваме на properties
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        HomeTown = homeTown;
    }
    //действия - чрез methods

    }


