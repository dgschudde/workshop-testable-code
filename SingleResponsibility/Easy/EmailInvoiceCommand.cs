﻿using TestableCodeDemos.SingleResponsibility.Shared;

namespace TestableCodeDemos.SingleResponsibility.Easy
{
    public class EmailInvoiceCommand
    {
        private readonly IDatabase _database;
        private readonly IInvoiceEmailer _emailer;

        public EmailInvoiceCommand(
            IDatabase database,
            IInvoiceEmailer emailer)
        {
            _database = database;
            _emailer = emailer;
        }

        public void Execute(int invoiceId)
        {
            var invoice = _database.GetInvoice(invoiceId);

            if (invoice.EmailAddress == string.Empty)
                throw new EmailAddressIsBlankException();

            _emailer.Email(invoice);
        }
    }
}
