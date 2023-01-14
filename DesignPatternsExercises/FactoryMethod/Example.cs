using DesignPatternsExercises.FactoryMethod.Services;

namespace DesignPatternsExercises.FactoryMethod
{
    internal class Example
    {
        public static void Run()
        {
            var jsonProductParser = new JsonProductService();
            var csvProductService = new CsvProductService();

            foreach (var file in Directory.GetFiles(Path.Combine(Directory.GetCurrentDirectory(), "FactoryMethod/Files")))
            {
                if(file.EndsWith("json"))
                {
                    Console.WriteLine($"JSON$");
                    Console.WriteLine($"Most expensive procuts costs {jsonProductParser.GetMostExpensiveProduct(file)} $");
                    Console.WriteLine($"We have {jsonProductParser.CountAllProducts(file)} products.");
                }
                else if (file.EndsWith("csv"))
                {
                    Console.WriteLine($"CSV");
                    Console.WriteLine($"Most expensive procuts costs {csvProductService.GetMostExpensiveProduct(file)} $");
                    Console.WriteLine($"We have {csvProductService.CountAllProducts(file)} products.");
                }
                else if (file.EndsWith("xml"))
                {
                    Console.WriteLine($"XML");
                    //Console.WriteLine($"Most expensive procuts costs {csvProductService.GetMostExpensiveProduct(file)} $");
                    //Console.WriteLine($"We have {csvProductService.CountAllProducts(file)} products.");
                }
            }
        }
    }
}
