namespace TestableCodeDemos.SingleResponsibility.Shared
{
    public class InvoiceWriter : IInvoiceWriter
    {
        public void Print(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
