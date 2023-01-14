namespace DesignPatternsExercises.Adapter
{
    internal interface IInvoiceService
    {
        public double CountTotalPriceInclVat(IInvoiceItem[] items);
        public double CountTotalPrice(IInvoiceItem[] items);
        public void PrintItems(IInvoiceItem[] items);
    }

    public interface IInvoiceItem
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public double Vat { get; }
        public double Price { get; }
        public int Count { get; }
    }

    public class InvoiceItem : IInvoiceItem
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; } = "";
        public double Vat { get; }
        public double Price { get; }
        public int Count { get; }

        public InvoiceItem(string name,
                           double price,
                           double vat,
                           int count)
        {
            Name = name;
            Price = price;
            Vat = vat;
            Count = count;
        }
    }

    public class OldInvoiceItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Dimension> Dimensions { get; set; }
    }

    public class Dimension
    {
        public double Vat { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
    }

    public class OldInvoiceAdapter : IInvoiceItem
    {
        private readonly OldInvoiceItem _oldInvoiceItem;

        public OldInvoiceAdapter(OldInvoiceItem oldInvoiceItem)
        {
            this._oldInvoiceItem = oldInvoiceItem;
        }

        public double Vat => _oldInvoiceItem.Dimensions.First().Vat;
        public double Price => _oldInvoiceItem.Dimensions.First().Price;
        public int Count => _oldInvoiceItem.Dimensions.First().Count;

        public int Id => _oldInvoiceItem.Id;
        public string Name => _oldInvoiceItem.Name;
        public string Description => "<no description>";
    }

    //TODO
    public class ThirdPartyInvoiceItem
    {
        public int Id { get; }
        public string Navn { get; }
        public string Beskrivelse { get; } = "";
        public double Mva { get; }
        public double Pris { get; }
        public int AntallElementer { get; }

    }
}
