namespace DesignPatternsExercises.Singleton.Services
{
    public class WarehouseService : IWarehuseService
    {
        public void AssignShippingDate(IParcelManager parcelManager) 
        {
            var toAssignShippingDate = parcelManager.Parcels.Where(p => p.ShippingDate == null)
                .OrderBy(p => p.IsPriority);

            var nextShippingDate = DateTime.Now.Date;
            int sum = 0;
            foreach (var item in toAssignShippingDate)
            {
                sum += item.Weight;

                if(sum > 1000)
                {
                    sum = 0;
                    nextShippingDate = nextShippingDate.AddDays(1);
                }

                item.ShippingDate = nextShippingDate;
            }
        }

        public void Print(IParcelManager parcelManager)
        {
            foreach (var parcel in parcelManager.Parcels)
            {
                Console.WriteLine($"Id: {parcel.Id.ToString("N")[..5]}; Name:{parcel.Name}; IsPriority: {parcel.IsPriority}; Shipping Date {(parcel.ShippingDate.HasValue ? parcel.ShippingDate.Value.ToShortDateString() : "none")} ");
            }
        }
    }
}
