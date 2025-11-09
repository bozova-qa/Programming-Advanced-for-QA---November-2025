using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [TestCase("Hello", 3, "hElLohElLohElLo")]
    [TestCase("HELLO world", 2, "hElLo wOrLdhElLo wOrLd")]
    [TestCase("Street #123", 3, "sTrEeT #123sTrEeT #123sTrEeT #123")]
    
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange - попълнили сме горе

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        // Arrange
        string input = string.Empty;
        int repetition = 2;
        string expected = "Input string cannot be empty, and repetition factor must be positive.";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetition));
    
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "Hello";
        int repetition = -2;
        string expected = "Input string cannot be empty, and repetition factor must be positive.";

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetition));
      

    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        // Arrange
        string input = "Hello";
        int repetition = 0;
        string expected = "Input string cannot be empty, and repetition factor must be positive.";
        
        // Act & Assert
        Assert.Throws<ArgumentException>(() => Pattern.GeneratePatternedString(input, repetition));
    }
}
