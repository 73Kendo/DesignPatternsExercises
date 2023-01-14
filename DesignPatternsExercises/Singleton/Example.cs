using DesignPatternsExercises.Singleton.Services;

namespace DesignPatternsExercises.Singleton
{
    public static class Example
    {
        public static void Run()
        {
            Worker1();
            Worker2();
            ShippingManager();
        }

        public static void Worker1()
        {
            IParcelManager pm = ParcelManager.GetInstance();
            AddParcel(pm);
            AddParcel(pm);
            AddParcel(pm);
            AddParcel(pm);
            AddParcel(pm);
        }

        public static void Worker2()
        {
            IParcelManager pm2 = ParcelManager.GetInstance();
            AddParcel(pm2);
            AddParcel(pm2);
            AddParcel(pm2);
            AddParcel(pm2);
            AddParcel(pm2);
        }

        public static void ShippingManager()
        {
            IWarehuseService ws = new WarehouseService();
            IParcelManager pm = ParcelManager.GetInstance(); 
            ws.AssignShippingDate(pm);
            ws.Print(pm);
        }

        public static void AddParcel(IParcelManager parcelManager)
        {
            var w = Random.Shared.Next(10, 1000);

            parcelManager.AddParcel(new Parcel(Guid.NewGuid(), w)
            {
                IsPriority = Random.Shared.Next(100) <= 50,
                Name = $"Parcel (w: {w})",
                Weight = w
            });
        }
    }
}
