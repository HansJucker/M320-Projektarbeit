using M320_Projektarbeit;
using M320_Projektarbeit.Employee;
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
        Assert.That(stockShouldBe == product.getUnitsInStock());     
         
        
    }

    [Test]
    public void Placing_An_Order_Should_Add_Units_To_Stock()
    {
        // Arrange
        var supplier = new Supplier("Meier Import", "Hauptstrasse 3, Sursee");
        var product = new Product("Tomaten", supplier);
        product.addUnitsToStock(10);
        int initialStock = product.getUnitsInStock();
        int unitsOrdered = 5;
        int stockShouldBe = initialStock + unitsOrdered;


        // Act
        Order o1 = new Order(product, product.getSupplier(), unitsOrdered);

        // Assert
        Assert.That(stockShouldBe == product.getUnitsInStock());

    }

    [Test]
    public void Adding_A_Delivery_Should_Add_Units_To_Stock()
    {
        // Arrange
        var supplier = new Supplier("Meier Import", "Hauptstrasse 3, Sursee");
        Driver dr1 = new Driver("Hans", "Feldstrasse 12, Ruswil", "CH12 1234 5678 9811", 4600);
        Customer c1 = new Customer("Migros", "Limmattalstrasse 12, Zürich");
        var product = new Product("Tomaten", supplier);
        product.addUnitsToStock(10);
        int initialStock = product.getUnitsInStock();
        int unitsOrdered = 5;
        int stockShouldBe = initialStock - unitsOrdered;


        // Act
        Delivery d1 = new Delivery(product, dr1 ,c1, unitsOrdered);

        // Assert
        Assert.That(stockShouldBe == product.getUnitsInStock());

    }
}