namespace TestableCodeDemos.SingleResponsibility.Shared
{
    public class Database : IDatabase
    {
        public Invoice GetInvoice(int invoiceId)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
