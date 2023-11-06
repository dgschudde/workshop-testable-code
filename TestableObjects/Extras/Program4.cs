using Ninject;
using Ninject.Extensions.Conventions;
using TestableCodeDemos.TestableObjects.Easy;

namespace TestableCodeDemos.TestableObjects.Extras
{
    public class Program4
    {
        static void Main_(string[] args)
        {
            var container = new StandardKernel();

            container.Bind(p =>
            {
                p.FromThisAssembly()
                    .SelectAllClasses()
                    .BindDefaultInterface();
            });

            var invoiceId = int.Parse(args[0]);

            var command = container.Get<PrintInvoiceCommand>();

            command.Execute(invoiceId);
        }
    }
}
