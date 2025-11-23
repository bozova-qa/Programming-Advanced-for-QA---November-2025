public class Program
{
    public static void Main(string[] args)
    {
        //class Program - създаваме обекти и пишем програмна логика
        List<Student> studentsList = new List<Student>();

        string input = Console.ReadLine(); //"John Smith 15 Sofia"

        while (input != "end")
        {
            string[] inputData = input.Split(" "); //["John", "Smith", "15", "Sofia"]
            string firstName = inputData[0];//"John"
            string lastName = inputData[1];//"Smith"
            int age = int.Parse(inputData[2]);//"15" -> 15
            string homeTown = inputData[3];//"Sofia"

            Student student = new Student(firstName, lastName, age, homeTown);//създаваме нов обект на базата на този, който сме създали в Students
            studentsList.Add(student);//добавяме обектите в списъка

            input = Console.ReadLine();
        }

        string searchedTown = Console.ReadLine(); //"Sofia"

        foreach (Student student in studentsList)
            {
                if(student.HomeTown == searchedTown)
                {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

       
    }

