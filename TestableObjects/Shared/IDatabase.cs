namespace TestableCodeDemos.TestableObjects.Shared
{
    public interface IDatabase
    {
        Invoice GetInvoice(int invoiceId);
    }
}