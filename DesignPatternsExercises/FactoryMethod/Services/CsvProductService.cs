using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExercises.FactoryMethod.Services
{
    internal class CsvProductService : ProductService
    {
        protected override IProductParser CreateParser()
        {
            return new CsvProductParser();
        }
    }
}
