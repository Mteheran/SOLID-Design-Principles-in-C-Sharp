namespace OCP
{
    public class InvoiceInternational : IInvoice, IInvoiceInternational
    {
        public decimal Subtotal { get; set; }
        public decimal TaxRate { get; set; }

        public decimal CalculateTax()
        {
            return Subtotal * TaxRate / 50;
        }

        public decimal CalculateTotal()
        {
            var result = Subtotal + CalculateTax() + 15;

            return result;
        }

        public decimal Tax_International()
        {
            var result = Subtotal + CalculateTax() + 10;

            return result;
        }
    }
}
