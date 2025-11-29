using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions _exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this._exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "Hello, world!";
        string expected = "!dlrow ,olleH";

        // Act
        string result = this._exceptions.ArgumentNullReverse(input);
        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    
    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;
        string expectedMessage = "String cannot be null.";

        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);

        //допълнителна логика за тестване на съобщението в грешката
        try
        {
            //Act -> throw exception
            _exceptions.ArgumentNullReverse(input);
        }
        catch (ArgumentNullException ex)
        {
            Assert.That(ex.Message, Does.Contain(expectedMessage));
        }

    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal inputPrice = 100;
        decimal discount = 20;
        decimal expected = 80;

        // Act
        decimal result = this._exceptions.ArgumentCalculateDiscount(inputPrice, discount);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    
    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal inputPrice = 100;
        decimal discount = -20;
       
        // Act & Assert
        Assert.That(() => this._exceptions.ArgumentCalculateDiscount(inputPrice, discount), Throws.ArgumentException);
        
        //логика за тестване на съобщението в грешката
        try
        {
            _exceptions.ArgumentCalculateDiscount(inputPrice, discount);
        }
        catch (ArgumentException ex)
        {
            Assert.That(ex.Message, Does.Contain("Discount must be between 0 and 100."));
        }
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal inputPrice = 100;
        decimal discount = 110;

        // Act & Assert
        ArgumentException ex = Assert.Throws<ArgumentException>(() => _exceptions.ArgumentCalculateDiscount(inputPrice, discount));
        Assert.That(ex.Message, Does.Contain("Discount must be between 0 and 100."));
    }


    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] input = { 20, 30, 40, 50 };
        int index = 2;
        int expected = 40;

        // Act
        int result = this._exceptions.IndexOutOfRangeGetElement(input, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] input = { 20, 30, 40, 50 };
        int index = -2;
        // Act & Assert
        Assert.That(() => this._exceptions.IndexOutOfRangeGetElement(input, index), 
            Throws.InstanceOf<IndexOutOfRangeException>());
    }

   
    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] input = { 10, 20, 30, 40, 50 };
        int index = input.Length;

        // Act & Assert
        IndexOutOfRangeException ind = Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(input, index));
        Assert.That(ind.Message, Does.Contain("Index is out of range."));
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] input = { 10, 20, 30, 40, 50 };
        int index = 5;

        //Act&Assert
        IndexOutOfRangeException ind = Assert.Throws<IndexOutOfRangeException>(() => _exceptions.IndexOutOfRangeGetElement(input, index));
        Assert.That(ind.Message, Does.Contain("Index is out of range."));
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool isLoggedIn = true;

        // Assert
        string result = this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn);

        //Assert
        Assert.That(result, Does.Contain("User logged in."));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        bool isLoggedIn = false;
        // Act & Assert
        Assert.That(() => this._exceptions.InvalidOperationPerformSecureOperation(isLoggedIn),
            Throws.InvalidOperationException);// или Throws.InstanceOf<InvalidOperationException>();
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "5";
        int expected = 5;

        // Act
        int result = this._exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string input = "five";

        // Act & Assert
        Assert.That(() => this._exceptions.FormatExceptionParseInt(input), 
            Throws.InstanceOf<FormatException>());

    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        // Arrage
        Dictionary<string, int> fruits = new() 
        { 
            { "Apple", 5 },
            { "Melon", 3}
        };
        string key = "Melon";
        int expected = 3;

        // Act
        int result = this._exceptions.KeyNotFoundFindValueByKey(fruits, "Melon");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, int> fruits = new()
        {
            { "Apple", 5 },
            { "Melon", 3}
        };
        

        // Act & Assert
        Assert.That(
            () => this._exceptions.KeyNotFoundFindValueByKey(fruits, "Pineapple"),
            Throws.InstanceOf<KeyNotFoundException>());

    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        int a = 5;
        int b = 3;
        int expected = 8;

        // Act
        int result = this._exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        //-2,147,483,648 to 2,147,483,647
        int a = 2147483647;
        int b = 1;

        // Act & Assert

        //OverflowException ofe = Assert.Throws<OverflowException>(
            //() => this._exceptions.OverflowAddNumbers(a, b));
       // Assert.That(ofe.Message, Does.Contain("Arithmetic overflow occurred during addition."));
        
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b),
            Throws.InstanceOf<OverflowException>());

    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        int a = -2147483648;
        int b = -1;

        // Act & Assert
        Assert.That(() => this._exceptions.OverflowAddNumbers(a, b),
            Throws.InstanceOf<OverflowException>());

    }

    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        int dividend = 4;
        int divisor = 2;
        int expected = 2;

        // Act
        int result = this._exceptions.DivideByZeroDivideNumbers(dividend, divisor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int dividend = 4;
        int divisor = 0;

        // Act & Assert
        Assert.That(() => this._exceptions.DivideByZeroDivideNumbers(dividend, divisor),
            Throws.InstanceOf<DivideByZeroException>());
    }

    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4 };
        int index = 3;
        int expected = 10;
        // Act
        int result = this._exceptions.SumCollectionElements(input, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] input = null;
        int index = 3;

        //Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(input, index),
            Throws.ArgumentNullException);
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] input = new int[] { 1, 2, 3, 4 };
        int index = 4;

        // Act & Assert
        Assert.That(() => this._exceptions.SumCollectionElements(input, index),
            Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange 
        Dictionary<string, string> input = new Dictionary<string, string>
        {
            { "apple", "3" },
            { "banana", "5"}
        };
        string key = "banana";
        int expected = 5;

        // Act
        int result = this._exceptions.GetElementAsNumber(input, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));

    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange 
        Dictionary<string, string> input = new Dictionary<string, string>
        {
            { "apple", "3" },
            { "banana", "5"}
        };
        string key = "5";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(input, key),
            Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>
        {
            { "apple", "3" },
            { "banana", "five"}
        };
        string key = "banana";

        // Act & Assert
        Assert.That(() => this._exceptions.GetElementAsNumber(input, key),
            Throws.InstanceOf<FormatException>());

    }
}
