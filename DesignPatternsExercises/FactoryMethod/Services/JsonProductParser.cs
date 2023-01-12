using DesignPatternsExercises.FactoryMethod.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace DesignPatternsExercises.FactoryMethod.Services
{
    internal class JsonProductParser : IProductParser
    {
        public IEnumerable<Product> Parse(string path)
        {
            return JsonConvert.DeserializeObject<IEnumerable<Product>>(File.ReadAllText(path)) ?? Enumerable.Empty<Product>();
        }
    }
}
