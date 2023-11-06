using TestableCodeDemos.TestableObjects.Easy;
using TestableCodeDemos.TestableObjects.Shared;

namespace TestableCodeDemos.TestableObjects.Extras
{
    public class PrintInvoiceCommandFactory
    {
        public PrintInvoiceCommand Create()
        {
            var command = new PrintInvoiceCommand(
                new Database(),
                new InvoiceWriter(
                    new Printer(),
                    new PageLayout()));

            return command;
        }
    }
}