try
{
    int number = int.Parse(Console.ReadLine());//the program will crash if we enter a string for example(Formatexception)
    if (number < 0)
    {
        throw new FormatException("Invalid number.");
    }
    else
    {
        //number >= 0
        Console.WriteLine(Math.Sqrt(number));
    }
}
catch (FormatException) //ако е по-малко от 0, хващаме FormatException и принтираме съобщението
{
    //number < 0
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}