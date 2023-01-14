using CsvHelper;
using DesignPatternsExercises.FactoryMethod.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExercises.FactoryMethod.Services
{
    public class CsvProductParser : IProductParser
    {
        IEnumerable<Product> IProductParser.Parse(string path)
        {
            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var products = csv.GetRecords<Product>().ToList();
                return products;
            }

        }
    }
}
