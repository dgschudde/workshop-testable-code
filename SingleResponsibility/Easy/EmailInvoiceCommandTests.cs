using Moq;
using Moq.AutoMock;
using NUnit.Framework;
using TestableCodeDemos.SingleResponsibility.Shared;

namespace TestableCodeDemos.SingleResponsibility.Easy
{
    [TestFixture]
    public class EmailInvoiceCommandTests
    {
        private EmailInvoiceCommand _command;
        private AutoMocker _mocker;
        private Invoice _invoice;

        private const int InvoiceId = 1;
        private const string EmailAddress = "email@test.com";

        [SetUp]
        public void SetUp()
        {
            _invoice = new Invoice
            {
                EmailAddress = EmailAddress
            };

            _mocker = new AutoMocker();

            _mocker.GetMock<IDatabase>()
                .Setup(p => p.GetInvoice(InvoiceId))
                .Returns(_invoice);

            _command = _mocker.CreateInstance<EmailInvoiceCommand>();
        }

        [Test]
        public void TestExecuteForInvoiceWithNoEmailAddressShouldThrowException()
        {
            _invoice.EmailAddress = string.Empty;

            Assert.That(() => _command.Execute(InvoiceId), 
                Throws.TypeOf<EmailAddressIsBlankException>());
        }

        [Test]
        public void TestExecuteShouldEmailInvoice()
        {
            _command.Execute(InvoiceId);

            _mocker.GetMock<IInvoiceEmailer>()
                .Verify(p => p.Email(_invoice),
                    Times.Once);
        }
    }
}
