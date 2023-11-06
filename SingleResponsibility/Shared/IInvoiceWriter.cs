namespace TestableCodeDemos.SingleResponsibility.Shared
{
    public interface IInvoiceWriter
    {
        void Print(Invoice invoice);
    }
}