namespace TestableCodeDemos.DependencyInjection.Easy;

public class Printer : IPrinter
{
    public void WriteLine(string text)
    {
        Console.WriteLine(text);
    }
}