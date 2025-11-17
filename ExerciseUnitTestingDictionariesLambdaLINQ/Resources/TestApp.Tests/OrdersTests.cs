using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        //Act
        string result = Orders.Order(input);

        //Assert
        Assert.That(result, Is.Empty);

    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2.50 3", "lemons 4.00 2", "kiwi 4.50 3" };
        string expected = "apple -> 7.50" + Environment.NewLine +
                           "lemons -> 8.00" + Environment.NewLine +
                           "kiwi -> 13.50";
        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2.561 3", "lemons 4.282 2", "kiwi 4.593 3" };
        string expected = "apple -> 7.68" + Environment.NewLine +
                           "lemons -> 8.56" + Environment.NewLine +
                           "kiwi -> 13.78";
        //Act
        string result = Orders.Order(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[] { "apple 2.50 3.20", "lemons 4.00 2.20", "kiwi 4.50 3.20" };
        string expected = "apple -> 8.00" + Environment.NewLine +
                           "lemons -> 8.80" + Environment.NewLine +
                           "kiwi -> 14.40";
        //Act
        string result = Orders.Order(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
