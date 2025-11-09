using NUnit.Framework;

using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace TestApp.UnitTests;

public class ReverseConcatenateTests
{
    
    [Test]
    public void Test_ReverseAndConcatenateStrings_EmptyInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    
    [Test]
    public void Test_ReverseAndConcatenateStrings_SingleString_ReturnsSameString()
    {
        // Arrange
        string[] input = new string[] { "hello" };
        string expected = "hello";

        // Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_MultipleStrings_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "hello", "hi", "Good evening" };
        string expected = "Good eveninghihello";

        //Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_NullInput_ReturnsEmptyString()
    {
        // Arrange
        string[] input = null;

        //Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_WhitespaceInput_ReturnsConcatenatedString()
    {
        // Arrange
        string[] input = new string[] { "hello dear", "hi" };
        string expected = "hihello dear";

        //Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ReverseAndConcatenateStrings_LargeInput_ReturnsReversedConcatenatedString()
    {
        // Arrange
        string[] input = new string[1000];
        
        for (int i = 0; i < 999; i++)
        {
            input[i] = i.ToString();// "1", "2", "3", "4"
        }

        //string expected:"999998997996995..."
        //правим stringbuilder, който да съхраняваме елементите, за да е по-бърза обработката


        StringBuilder sb = new StringBuilder();

        for (int i = input.Length - 1; i >= 0; i--)
        {
            sb.Append(input[i]);// добавяме i към StringBuilder-a в обратен ред;
        }
        string expected = sb.ToString();//"999998997996995..."

        //Act
        string result = ReverseConcatenate.ReverseAndConcatenateStrings(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
