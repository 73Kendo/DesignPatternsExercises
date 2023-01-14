
namespace DesignPatternsExercises.Builder
{
    internal class CarBuilder : ICarBuilder
    {
        private Car _car = new();

        public Car GetCar()
        {
             Car result = _car;
            this.Reset();
            return result;
        }

        public void Reset()
        {
            _car = new();
        }

        public ICarBuilder SetEngine(Engine engine)
        {
            _car.Engine = engine;
            return this;
        }

        public ICarBuilder SetModel(Model model)
        {
            _car.Model = model;
            return this;
        }

        public ICarBuilder SetProductionDate(DateTime date)
        {
            _car.ProductionDate = date;
            return this;
        }
    }
}
