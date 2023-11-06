using TestableCodeDemos.DependencyInjection.Shared;

namespace TestableCodeDemos.DependencyInjection.Easy;

public interface IDatabase
{
    Invoice GetInvoice(int invoiceId);
}