using M320_Projektarbeit;
using M320_Projektarbeit.Produkte;
using NUnit.Framework;

namespace ClassLibrary1;


[TestFixture]
public class ProductTests
{
    [Test]
    public void RemoveUnitsFromStock_ShouldDecreaseUnitsInStock()
    {
        // Arrange
        var supplier = new Supplier("Meier Import", "Hauptstrasse 3, Sursee");
        var product = new Product("Tomaten",supplier);
        product.addUnitsToStock(10);
        int initialStock = product.getUnitsInStock();
        int unitsToRemove = 5;
        int stockShouldBe = initialStock - unitsToRemove;

        // Act
        product.removeUnitsFromStock(unitsToRemove);

        // Assert
        Assert.That(initialStock - unitsToRemove == product.getUnitsInStock());     
         
        
    }
}