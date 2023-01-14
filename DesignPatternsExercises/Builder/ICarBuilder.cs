using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExercises.Builder
{
    internal interface ICarBuilder
    {
        public void Reset();

        public Car GetCar();

        public ICarBuilder SetModel(Model model);

        public ICarBuilder SetEngine(Engine engine);

        public ICarBuilder SetProductionDate(DateTime date);
 
    }
}
