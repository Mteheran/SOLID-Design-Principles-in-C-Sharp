namespace OCP
{
    public interface IInvoice
    {
        decimal Subtotal { get; set; }
        decimal TaxRate { get; set; }

        decimal CalculateTax();

        decimal CalculateTotal();

    }
}
