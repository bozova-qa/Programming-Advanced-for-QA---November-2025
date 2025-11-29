int number = int.Parse(Console.ReadLine());

if(number < 0)
{
    throw new ArgumentException("Entered number is below zero.");//искаме да прекратим програмата с това съобщение
}
else
{
    Console.WriteLine(number * number);
}