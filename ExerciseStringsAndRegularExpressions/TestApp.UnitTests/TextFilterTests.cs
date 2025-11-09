using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    // TODO: finish the test
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = new string[] { "carrot", "apple" };
        string text = "Als der Australier Lindsay in Bombay strandet, hat er zwei Jahre Gefängnis hinter sich und ist auf der Flucht vor Interpol.";
    
        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string[] bannedWords = new string[] { "Australier", "Bombay", "Gefängnis" };
        string text = "Als der Australier Lindsay in Bombay strandet, hat er zwei Jahre Gefängnis hinter sich und ist auf der Flucht vor Interpol.";
        string expected = "Als der ********** Lindsay in ****** strandet, hat er zwei Jahre ********* hinter sich und ist auf der Flucht vor Interpol.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string[] bannedWords = Array.Empty<string>();
        string text = "Als der Australier Lindsay in Bombay strandet, hat er zwei Jahre Gefängnis hinter sich und ist auf der Flucht vor Interpol.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string[] bannedWords = new string[] { "Bombay strandet" };
        string text = "Als der Australier Lindsay in Bombay strandet, hat er zwei Jahre Gefängnis hinter sich und ist auf der Flucht vor Interpol.";
        string expected = "Als der Australier Lindsay in ***************, hat er zwei Jahre Gefängnis hinter sich und ist auf der Flucht vor Interpol.";

        // Act
        string result = TextFilter.Filter(bannedWords, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));



        ////пример с "Bombay "
        //string result = TextFilter.Filter(bannedWords, text);
        //string adjusted = result.Replace("*******strandet", "******* strandet");
        //Assert.That(adjusted, Is.EqualTo("Als der Australier Lindsay in * strandet, hat er zwei Jahre Gefängnis hinter sich und ist auf der Flucht vor Interpol."));
    }
}
