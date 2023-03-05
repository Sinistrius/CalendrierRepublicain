namespace Sinistrius.CalendrierRepublicain.UnitTests;


/// <summary>
/// Tests the <see cref="String"/> class.
/// </summary>
[TestClass]
public class StringTests
{

    /// <summary>
    /// Tests the <see cref="String.Format(IFormatProvider?, string, object?[])"/> method.
    /// </summary>
    [TestMethod]
    [DataRow(1, 1, 1, "D", "Primidi, 1. Vend�miaire I")]
    [DataRow(1, 1, 1, "d. MMMM yyyy", "1. Vend�miaire I")]
    [DataRow(1, 1, 1, "d. MMM. yyyy", "1. Vend. I")]
    [DataRow(3, 13, 6, "D", "Jour de la r�volution III")]
    [DataRow(3, 13, 6, "d. MMMM yyyy", "Jour de la r�volution III")]
    [DataRow(3, 13, 6, "d. MMM. yyyy", "Jour de la r�volution III")]
    [DataRow(14, 4, 10, "D", "D�cadi, 10. Niv�se XIV")]
    [DataRow(14, 4, 10, "d. MMMM yyyy", "10. Niv�se XIV")]
    [DataRow(14, 4, 10, "d. MMM. yyyy", "10. Niv. XIV")]
    public void Format_FrenchRepublicanDate_ReturnsFormattedString(int year, int month, int day, string format, string expectedString)
    {
        // Arrange
        FrenchRepublicanDateTimeFormatter provider = new();
        FrenchRepublicanDateTime time = new(year, month, day, 1);
        format = $"{{0:{format}}}";

        // Act
        string actualString = String.Format(provider, format, time);

        // Assert
        Assert.AreEqual(expectedString, actualString);
    }

}