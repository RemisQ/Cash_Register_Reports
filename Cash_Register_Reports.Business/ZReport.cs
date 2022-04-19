using System;

namespace Cash_Register_Reports.Business
{
    public class ZReport
    {
        public int Id { get; }
        public ReportInfo ReportInfo { get; }
        public SalesAndTaxes SalesAndTaxes { get; }
        public CashOperations CashOperations { get; }

        public ZReport(int id, ReportInfo reportInfo, SalesAndTaxes salesAndTaxes, CashOperations cashOperations)
        {
            Id = id;
            ReportInfo = reportInfo;
            SalesAndTaxes = salesAndTaxes;
            CashOperations = cashOperations;
        }
    }
}
