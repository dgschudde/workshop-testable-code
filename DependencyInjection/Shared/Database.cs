using TestableCodeDemos.DependencyInjection.Easy;

namespace TestableCodeDemos.DependencyInjection.Shared
{
    public class Database : IDatabase
    {
        public Invoice GetInvoice(int invoiceId)
        {
            throw new System.NotImplementedException();
        }
    }
}