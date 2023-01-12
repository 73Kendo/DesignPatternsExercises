namespace DesignPatternsExercises.Singleton.Services
{
    public interface IWarehuseService
    {
        void AssignShippingDate(IParcelManager parcelManager);

        void Print(IParcelManager parcelManager);
    }
}
