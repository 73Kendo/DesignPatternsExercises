namespace DesignPatternsExercises.Builder
{
    public static class Example
    {
        public static void Run()
        {
            IPersonBuilder personBuilder = new PersonBuilder();

            var person = personBuilder.SetGiven("Jan")
                .SetFamily("Nowak")
                .SetBirthDate(new DateTime(1990, 01, 01))
                .SetGender(Gender.M)
                .GetPerson();

            Console.WriteLine(person);
        }
    }
}
