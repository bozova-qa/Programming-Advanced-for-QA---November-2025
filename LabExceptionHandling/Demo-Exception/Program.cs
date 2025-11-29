int price = int.Parse("4.6");// System.FormatException; текстът, който задаваме, не е в правилния формат

List<int> listNumbers = null;
listNumbers.Add(4);//->NullReferenceException -> it doesn't reference any actual object in memory; there's no object to call the method on.

/*int[] numbers = new int[] { 2, 3, 4, 5, 6 };
Console.WriteLine(numbers[10]);*/ //IndexOutOfRangeException

//Exception -
//1. грешка в програмата, която се получава по време на изпълнение;
//2. тя прекратява цялата програма
//3.части - вид, съобщение, stacktrance (от кой ред идва нашата грешка)

//Index out of range exception - програмата се прекратява, всичко под този ред не се изпълнява

int number = 0;
Console.WriteLine(5 / number);
//DevideByZeroException


Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
Console.WriteLine("Hello");
