using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(input);

        //Assert
        Assert.That(result, Is.Empty);

    }

    
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] input = new string[] { "Pine" };
        string expected = "Plants with 4 letters:" + Environment.NewLine +
                            "Pine";
        // Act
        string result = Plants.GetFastestGrowing(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] input = new string[] { "Pine", "Oak", "Maple" };
        string expected = "Plants with 3 letters:" + Environment.NewLine + "Oak" + Environment.NewLine +
                        "Plants with 4 letters:" + Environment.NewLine + "Pine" + Environment.NewLine +
                        "Plants with 5 letters:" + Environment.NewLine + "Maple";
        // Act
        string result = Plants.GetFastestGrowing(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] input = new string[] { "PinE", "OaK", "MaPle" };
        string expected = "Plants with 3 letters:" + Environment.NewLine + "OaK" + Environment.NewLine +
                        "Plants with 4 letters:" + Environment.NewLine + "PinE" + Environment.NewLine +
                        "Plants with 5 letters:" + Environment.NewLine + "MaPle";
        // Act
        string result = Plants.GetFastestGrowing(input);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
