using DesignPatternsExercises.FactoryMethod.Model;

namespace DesignPatternsExercises.Decorator
{
    internal class Example
    {
        public static void Run()
        {
            var product1 = new Product { CategoryID = 3, Discontinued = false, ProductID = 19, ProductName = "Teatime Chocolate Biscuits", QuantityPerUnit = "10 boxes x 12 pieces", ReorderLevel = 5, SupplierID = 8, UnitPrice = 9.2m, UnitsInStock = 25, UnitsOnOrder = 0 };
            var product2 = new Product { CategoryID = 3, Discontinued = false, ProductID = 20, ProductName = "Sir Rodney's Marmalade", QuantityPerUnit = "30 gift boxes", ReorderLevel = 0, SupplierID = 8, UnitPrice = 81, UnitsInStock = 40, UnitsOnOrder = 0 };

            IProductStore ps = new EcryptedProductStoreDecorator(new ProductStore());

            var serialized = ps.Serialize(new[] { product1, product2 });
            File.WriteAllText("out.json", serialized);

            var content = File.ReadAllText("out.json");

            ps.Deserialize(content);
        }
    }
}
