namespace DesignPatternsExercises.Builder
{
    public static class Example
    {
        public static void Run()
        {
            IPersonBuilder personBuilder = new PersonBuilder();
            ICarBuilder carBuilder  = new CarBuilder();

            var person = personBuilder.SetGiven("Jan")
                .SetFamily("Nowak")
                .SetBirthDate(new DateTime(1990, 01, 01))
                .SetGender(Gender.M)
                .GetPerson();
            
            
            var car = carBuilder
                .SetModel(Model.Auris)
                .SetEngine(Engine.Hybrid)
                .SetProductionDate(DateTime.Now)
                .GetCar();
            Console.WriteLine(person);
            Console.WriteLine(car);
        }
    }
}
