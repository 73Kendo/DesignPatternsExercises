using DesignPatternsExercises.FactoryMethod.Model;

namespace DesignPatternsExercises.FactoryMethod.Services
{
    //IProduct
    internal interface IProductParser
    {
        IEnumerable<Product> Parse(string path);
    }
}
