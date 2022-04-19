using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register_Reports.Business
{
    public class CashOperations
    {
        public decimal InsertedCash { get; }
        public decimal CollectedCash { get; }
        public decimal CashBalance { get; }
        public int TotalReceipts { get; }

        public CashOperations(decimal insertedCash, decimal collectedCash, decimal cashBalance, int totalReceipts)
        {
            InsertedCash = insertedCash;
            CollectedCash = collectedCash;
            CashBalance = cashBalance;
            TotalReceipts = totalReceipts;
        }
    }
}
