using DesignPatternsExercises.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExercises.Adapter
{
    internal class Example
    {
        public static void Run()
        {
            var items = new List<IInvoiceItem>()
            {
                new InvoiceItem("beer", 10, 0.23, 3),
                new OldInvoiceAdapter(new OldInvoiceItem {
                    Id= 1,
                    Name = "beer",
                    Dimensions= new List<Dimension>
                    {
                        new Dimension
                        {
                            Count= 3,
                            Price= 10,
                            Vat = 0.23
                        }
                    }
                })
            };

            IInvoiceService invoiceService = new InvoiceService();
            invoiceService.PrintItems(items.ToArray());
        }
    }
}
