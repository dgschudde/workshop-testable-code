using TestableCodeDemos.DependencyInjection.Shared;

namespace TestableCodeDemos.DependencyInjection.Hard
{
    public class PrintInvoiceCommand
    {
        public void Execute(int invoiceId)
        {
            var database = new Database();

            var invoice = database.GetInvoice(invoiceId);

            Printer.WriteLine("Invoice ID: " + invoice.Id);

            Printer.WriteLine("Total: € " + invoice.Total);

            var dateTime = DateTime.Now;

            Printer.WriteLine("Printed: " + dateTime.ToShortDateString());
        }
    }
}
