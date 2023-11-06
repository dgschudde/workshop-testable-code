namespace TestableCodeDemos.SingleResponsibility.Shared
{
    public interface ISecurity
    {
        string GetUserName();

        bool IsAdmin();
    }
}
