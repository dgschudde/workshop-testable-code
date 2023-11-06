using TestableCodeDemos.TestableObjects.Shared;

namespace TestableCodeDemos.TestableObjects.Easy
{
    public interface IInvoiceWriter
    {
        void Write(Invoice invoice);
    }
}