using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public interface IInvoice
    {
        decimal Subtotal { get; set; }

        decimal TaxRate { get; set; }

        decimal CalculateTax();

        decimal CalculateTotal();
    }
}
