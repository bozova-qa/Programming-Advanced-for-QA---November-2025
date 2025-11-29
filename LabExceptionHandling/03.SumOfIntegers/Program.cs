string[] input = Console.ReadLine().Split();
//"2147483649 2 3.4 5 invalid 24 -4" -> ["2147483649", "2", "3.4", "5", "invalid", "24", "-4"]

int sum = 0;

foreach (string element in input)
{
    //1. проверка дали element е цяло число
    //2. проверка дали цялото число може да се съхрани в int променлива
    //int type range in C#: -2,147,483,648 to 2,147,483,647
    try
    {
        int number = int.Parse(element);//опитваме да пеобразуваме всеки един елемент в число, за да проверим дали е число
        //ако не е число, получаваме FormatException
        //Overflowexception - получава се, когато в една целочислена променлива се опитаме да съхраним по-голямо число, отколкото тя може да побере
        sum += number;
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{element}' is in wrong format!");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"The element '{element}' is out of range!");
    }
    finally
    {
        Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
    }


}
Console.WriteLine($"The total sum of all integers is: {sum}");