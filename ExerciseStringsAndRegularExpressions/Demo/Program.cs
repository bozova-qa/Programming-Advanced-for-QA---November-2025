int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("even");
}
else
{
    Console.WriteLine("odd");
}

// тернарен оператор

string result = number % 2 == 0 ? "even" : "odd";//ако е вярно - even, ако не - odd
Console.WriteLine(result);