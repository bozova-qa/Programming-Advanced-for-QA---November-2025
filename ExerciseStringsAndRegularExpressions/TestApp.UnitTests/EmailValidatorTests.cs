using NUnit.Framework;

namespace TestApp.UnitTests;

public class EmailValidatorTests
{
    
    [TestCase("boyan.petrov@gmail.com")]
    [TestCase("bobi+123@gmail.com")]
    [TestCase("bobo_%@abv.ru")]
    public void Test_ValidEmails_ReturnsTrue(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);

        // Assert
        Assert.That(result, Is.True);
    }

    
    [TestCase("boyan.petrov@gmail.c")]
    [TestCase("bobi#123@gmail.com")]
    [TestCase("boyan.petrov@gmail")]
    public void Test_InvalidEmails_ReturnsFalse(string email)
    {
        // Arrange

        // Act
        bool result = EmailValidator.IsValidEmail(email);
        
        // Assert
        Assert.That(result, Is.False);
    }
}
