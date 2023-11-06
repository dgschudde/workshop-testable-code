namespace TestableCodeDemos.DependencyInjection.Easy;

public class DateTimeWrapper : IDateTimeWrapper
{
    public DateTime GetNow()
    {
        return DateTime.Now;
    }
}