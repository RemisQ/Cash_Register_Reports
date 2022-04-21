using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register_Reports.Business
{
    public class XReport
    {
        public ReportInfo ReportInfo { get; }
        public SalesAndTaxes SalesAndTaxes { get; }
        public CashOperations CashOperations { get; }

        public XReport(ReportInfo reportInfo, SalesAndTaxes salesAndTaxes, CashOperations cashOperations)
        {
            ReportInfo = reportInfo;
            SalesAndTaxes = salesAndTaxes;
            CashOperations = cashOperations;
        }
    }
}
