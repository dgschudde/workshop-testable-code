namespace TestableCodeDemos.SingleResponsibility.Shared
{
    public interface IEmailValidator
    {
        bool IsValid(string address);
    }
}
