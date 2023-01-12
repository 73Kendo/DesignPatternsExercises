namespace DesignPatternsExercises.Builder
{
    internal class PersonBuilder : IPersonBuilder
    {
        private Person _person = new();

        public void Reset() { _person = new(); }

        public Person GetPerson()
        {
            if (string.IsNullOrEmpty(_person.Given) || string.IsNullOrEmpty(_person.Family))
                throw new ArgumentNullException("Given and Family can't be empty.");

            Person result = _person;
            this.Reset();
            return result;
        }

        public IPersonBuilder SetGiven(string name)
        {
            _person.Given = name;
            return this;
        }

        public IPersonBuilder SetFamily(string family)
        {
            _person.Family = family;
            return this;
        }

        public IPersonBuilder SetBirthDate(DateTime dob)
        {
            _person.BirthDate = dob;
            return this;
        }

        public IPersonBuilder SetGender(Gender gender)
        {
            _person.Gender = gender;
            return this;
        }

        public IPersonBuilder SetPhone(string phone)
        {
            _person.Phone = phone;
            return this;
        }
    }
}
