using TestableCodeDemos.TestableObjects.Easy;
using TestableCodeDemos.TestableObjects.Shared;

namespace TestableCodeDemos.TestableObjects.Extras
{
    public class Program
    {
        static void Main_(string[] args)
        {
            var invoiceId = int.Parse(args[0]);

            var command = new PrintInvoiceCommand(
                new Database(), 
                new InvoiceWriter(
                    new Printer(), 
                    new PageLayout()));

            command.Execute(invoiceId);
        }
    }
}
