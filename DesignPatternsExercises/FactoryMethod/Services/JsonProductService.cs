namespace DesignPatternsExercises.FactoryMethod.Services
{
    internal class JsonProductService : ProductService
    {
        protected override IProductParser CreateParser()
        {
            return new JsonProductParser();
        }
    }
}
