namespace DesignPatternsExercises.Singleton
{
    public interface IParcelManager
    {
        public List<Parcel> Parcels { get; set; }

        void AddParcel(Parcel parcel);

    }

    public class ParcelManager : IParcelManager
    {
        public List<Parcel> Parcels { get; set; } = new List<Parcel>();

        public void AddParcel(Parcel parcel)
        {
            Parcels.Add(parcel);
        }
    }
}
