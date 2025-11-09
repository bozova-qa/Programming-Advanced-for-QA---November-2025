string input = Console.ReadLine();

while (input != "end")
{
    string reversedText = "";//въведеният текст наобратно
    for (int position = input.Length - 1;position >= 0; position--)
    {
        char currentSymbol = input[position];
        reversedText += currentSymbol;

    }
    //input имаме думата Hello
    //reversedText olleH
    Console.WriteLine(input + " = " + reversedText);

    input = Console.ReadLine();
}
