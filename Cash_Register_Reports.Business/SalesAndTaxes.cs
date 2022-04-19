using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register_Reports.Business
{
    public class SalesAndTaxes
    {
        public decimal TurnoverWithVat { get; }
        public decimal Vat21 { get; }
        public decimal TurnoverByCash { get; }
        public decimal TurnoverByCard { get; }

        public SalesAndTaxes(decimal turnoverWithVat, decimal vat21, decimal turnoverByCash, decimal turnoverByCard)
        {
            TurnoverWithVat = turnoverWithVat;
            Vat21 = vat21;
            TurnoverByCash = turnoverByCash;
            TurnoverByCard = turnoverByCard;
        }
    }
}
