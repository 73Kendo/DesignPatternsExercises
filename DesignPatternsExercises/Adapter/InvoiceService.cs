namespace DesignPatternsExercises.Adapter
{
    internal class InvoiceService : IInvoiceService
    {
        public double CountTotalPrice(IInvoiceItem[] items)
        {
            return items.Sum(it => it.Price * it.Count);
        }

        public double CountTotalPriceInclVat(IInvoiceItem[] items)
        {
            return items.Sum(it => it.Count * (it.Price + it.Price * it.Vat));
        }

        public void PrintItems(IInvoiceItem[] items)
        {
            foreach (var item in items)
            {
                Console.WriteLine($"name: {item.Name}, price: {item.Price}, count: {item.Count}, vat: {item.Vat}");
            }
        }
    }
}
