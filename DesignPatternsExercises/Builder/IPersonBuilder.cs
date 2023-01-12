using DesignPatternsExercises.FactoryMethod.Model;

namespace DesignPatternsExercises.Builder
{
    internal interface IPersonBuilder
    {
        public void Reset();

        public Person GetPerson();

        public IPersonBuilder SetGiven(string name);

        public IPersonBuilder SetFamily(string family);

        public IPersonBuilder SetBirthDate(DateTime date);

        public IPersonBuilder SetGender(Gender gender);

        public IPersonBuilder SetPhone(string phone);
    }
}
