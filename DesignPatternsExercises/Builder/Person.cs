using System.Text;

namespace DesignPatternsExercises.Builder
{
    public class Person
    {
        public Guid Id { get; set; }

        public string Given { get; set; }
        public string Family { get; set; }
        public Address PostalAddress { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Phone { get; set; }
        public LangCode PreferedLanguage { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Given: {Given}");
            sb.AppendLine($"Family: {Family}");
            sb.AppendLine($"DateOfBirth: {BirthDate.ToShortDateString()}");
            sb.AppendLine($"Gender: {Gender}");

            return sb.ToString();
        }
    }

    public enum Gender
    {
        M,
        F
    }

    public enum LangCode
    {
        PL,
        EN,
        DE,
        FR,
    }

    public class Address
    {
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
    }
}
