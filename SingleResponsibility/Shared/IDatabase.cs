namespace TestableCodeDemos.SingleResponsibility.Shared
{
    public interface IDatabase
    {
        Invoice GetInvoice(int invoiceId);

        void Save();
    }
}
