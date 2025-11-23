int n = int.Parse(Console.ReadLine());

List<Student> students = new List<Student>();//правим списък със Students

for (int i = 0; i < n; i++)
{
    string[] studentsInfo = Console.ReadLine().Split().ToArray();
    string firstName = studentsInfo[0];
    string lastName = studentsInfo[1];
    double grade = double.Parse(studentsInfo[2]);

    Student currentStudent = new Student(firstName, lastName, grade);//създаваме нова инстанция(нов обект) и подаваме данните  
    
    //добавяме текущия ученик към списъка
    students.Add(currentStudent);
}

List<Student> orderedStudents = students.OrderByDescending(s => s.Grade).ToList();
//s - взимаме първата буква от students, сортира по оценки;

foreach (Student student in orderedStudents)
{
    Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; } 
    public double Grade { get; set; }

    public Student(string firstName, string lastName, double grade)
    {
        FirstName = firstName;
        LastName = lastName;
        Grade = grade;
    }
}

