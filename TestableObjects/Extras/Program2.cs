namespace TestableCodeDemos.TestableObjects.Extras
{
    public class Program2
    {
        static void Main_(string[] args)
        {
            var invoiceId = int.Parse(args[0]);

            var factory = new PrintInvoiceCommandFactory();

            var command = factory.Create();

            command.Execute(invoiceId);
        }
    }
}
