namespace DesignPatternsExercises.Singleton
{
    public interface IParcelManager
    {
        public List<Parcel> Parcels { get; set; }

        void AddParcel(Parcel parcel);

    }

    public class ParcelManager : IParcelManager
    {
        private ParcelManager() { }
        
        private static ParcelManager? _instance;
        public List<Parcel> Parcels { get; set; } = new List<Parcel>();

        public static ParcelManager GetInstance()
        {
            if(_instance==null)
            {
                _instance = new ParcelManager();
            }
            return _instance;
        }

        public void AddParcel(Parcel parcel)
        {
            Parcels.Add(parcel);
        }
    }
}
