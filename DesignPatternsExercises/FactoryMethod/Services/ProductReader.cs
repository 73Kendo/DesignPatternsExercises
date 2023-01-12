namespace DesignPatternsExercises.FactoryMethod.Services
{
    internal abstract class ProductService
    {
        protected abstract IProductParser CreateParser();

        public decimal GetMostExpensiveProduct(string filePath)
        {
            var parser = CreateParser();
            return parser.Parse(filePath).Max(m => m.UnitPrice) ?? 0;
        }

        public int CountAllProducts(string filePath)
        {
            var parser = CreateParser();
            return parser.Parse(filePath).Sum(m => m.UnitsInStock ?? 0);
        }
    }
}
