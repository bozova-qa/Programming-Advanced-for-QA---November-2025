//Handling exceptions = обработка на exceptions, да не позволяваме те да прекратяват програмата

int[] numbers = new int[] { 1, 2, 3, 4 };

try
{
    Console.WriteLine(numbers[10]);//IndexOutOfRangeException //кодът, при който се появява Exception
}
catch //не прекъсвай програмата, вместо това, изпълни кога в скобите
{
    //получаваме и обработваме exception-a, за да не прекрати цялата програма
    Console.WriteLine("Exception was handled.");
}
finally
{
    //код, който винаги се изпълнява; 
    Console.WriteLine("Everything is over!");
}


Console.WriteLine("Hello world!");
Console.WriteLine("Hello world!");
Console.WriteLine("Hello world!");
Console.WriteLine("Hello world!");

int number = 0;

try
{
    Console.WriteLine(number);
    Console.WriteLine(number + 6);
    Console.WriteLine(int.Parse("4.5"));//FormatException
    Console.WriteLine(number / 0);//ArithmeticException
    Console.WriteLine(numbers[20]);// IndexOutOfRangeException
}
//хваща абослютно всеки Exception
catch (FormatException formatException)//хваща само този exception и го запазва в променливата formatException
//formatException - обект, който съхранява хванатия exception
{
    Console.WriteLine(formatException.Message);//отпечатва съобщението
    Console.WriteLine(formatException.StackTrace);//отпечатва къде се е появил exception
    Console.WriteLine("FormatException handled!");
}
catch (ArithmeticException arException)//може и да не я съхраняваме в променлива
{
    Console.WriteLine("ArithmeticException handled!");
}
catch (IndexOutOfRangeException iorException)
{
    Console.WriteLine("IndexOutOfRangeException handled!");
}
finally
{
    Console.WriteLine("Over");
}