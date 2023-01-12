namespace DesignPatternsExercises.Singleton
{
    public class Parcel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public int Weight { get; set; }

        public DateTime? ShippingDate { get; set; }

        public bool IsPriority { get; set; }

        public Parcel(Guid id, int weight)
        {
            Id = id;
        }
    }

    public enum Status
    {
        New,
        Waiting,
        Loaded
    }
}
