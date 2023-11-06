namespace TestableCodeDemos.SingleResponsibility.Shared
{
    public interface IInvoiceEmailer
    {
        void Email(Invoice invoice);
    }
}