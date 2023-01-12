using DesignPatternsExercises.FactoryMethod.Services;

namespace DesignPatternsExercises.FactoryMethod
{
    internal class Example
    {
        public static void Run()
        {
            var jsonProductParser = new JsonProductService();

            foreach (var file in Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "FactoryMethod/Files")))
            {
                if(file.EndsWith("json"))
                {
                    Console.WriteLine($"Most expensive procuts costs {jsonProductParser.GetMostExpensiveProduct(file)} $");
                    Console.WriteLine($"We have {jsonProductParser.CountAllProducts(file)} products.");
                }
            }
        }
    }
}
