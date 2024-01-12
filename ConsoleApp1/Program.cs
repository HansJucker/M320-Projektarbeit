using System;
using M320_Projektarbeit;
using M320_Projektarbeit.Employee;
using M320_Projektarbeit.Produkte;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;


namespace M320_Projektarbeit
{
    class Program
    {
        static void Main(string[] args)
        {


            Supplier s1 = new Supplier("Meier Import", "Hauptstrasse 3, Sursee");
            Supplier s2 = new Supplier("Müller Grosshandel", "Bahnhofstrasse 13, Luzern");

            Customer c1 = new Customer("Migros", "Limmattalstrasse 12, Zürich");
            Customer c2 = new Customer("Coop", "Industriestrasse 17, Wangen bei Olten");

            Food f1 = new Food("Eier", s1, DateTime.Now.AddDays(30));
            Food f2 = new Food("Milch", s2, DateTime.Now.AddDays(10));

            Plants p1 = new Plants("Rosen", s2, 0.99, 2.2, DateTime.Now.AddDays(5));
            Plants p2 = new Plants("Tulpen", s2, DateTime.Now.AddDays(7));

            Electronics e1 = new Electronics("Kopfhörer X1", s1, "Logitech");
            Electronics e2 = new Electronics("Tastatur Z5", s1, 100, 30, 80, "Apple");

            Driver dr1 = new Driver("Hans", "Feldstrasse 12, Ruswil", "CH12 1234 5678 9811", 4600);
            Driver dr2 = new Driver("Joachim", "Rennweg 8, Zürich", "CH12 1234 5678 9800", 4200);

            Logistician lo1 = new Logistician("Christian", "Haupstrasse 4", "CH12 1234 5678 9855", 4100, true);

            Manager ma1 = new Manager("Dennis", "Paradeplatz 3, Zürich", "CH12 1234 5678 9844", 8000, 5000);

            p2.setUnitsInStock(120);
            p2.addUnitsToStock(13);
            p1.addUnitsToStock(222);
            f1.addUnitsToStock(300);
            e2.removeUnitsFromStock(23);
            e2.removeUnitsFromStock(1000);
            dr1.addCustomer(c1);
            dr1.addCustomer(c2);
            dr1.addCustomer(c2);
            p1.setExpirationDate(DateTime.Now.AddDays(12));           


            Order o1 = new Order(p1, p1.getSupplier(), 150);
            Order o2 = new Order(e2, e2.getSupplier(), 30);
            Order o3 = new Order(p2, p2.getSupplier(), 12);


            Delivery d1 = new Delivery(f1, dr2, c2, 50);
            Delivery d2 = new Delivery(e1, dr1, c1, 12);
            Delivery d3 = new Delivery(p1, dr1, c1, 77);

            Console.WriteLine($"There are now {p1.getUnitsInStock()} {p1.getProductName()} in stock");
            Console.WriteLine($"There are now {e2.getUnitsInStock()} {e2.getProductName()} in stock");
            Console.WriteLine($"The expiration date for {p1.getProductName()} is {p1.getExpirationDate()}");

            d1.getDeliveryDetails();

            s1.printOrder();
            s2.printOrder();

            
            Console.WriteLine($"There are now {p1.getUnitsInStock()} {p1.getProductName()} in stock");

            c1.printDeliveryDetails();
            
            Console.ReadLine();


        }
    }
}