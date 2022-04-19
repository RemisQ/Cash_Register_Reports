using Cash_Register_Reports.Business;
using System;
using System.Collections.Generic;

namespace Cash_Register_Reports.DataAccess
{
    public class ZReportRepository
    {
        
        private List<ZReport> zReports { get; }
        

        public ZReportRepository()
        {
            
            zReports = new List<ZReport>();
            

            ReportInfo reportInfo1 = new ReportInfo("January", 1, DateTime.Now);
            ReportInfo reportInfo2 = new ReportInfo("January", 2, DateTime.Now);
            ReportInfo reportInfo3 = new ReportInfo("January", 3, DateTime.Now);
            ReportInfo reportInfo4 = new ReportInfo("January", 4, DateTime.Now);
            ReportInfo reportInfo5 = new ReportInfo("January", 5, DateTime.Now);
            ReportInfo reportInfo6 = new ReportInfo("January", 6, DateTime.Now);
            ReportInfo reportInfo7 = new ReportInfo("January", 7, DateTime.Now);


            SalesAndTaxes salesAndTaxes1 = new SalesAndTaxes(1001, 189.15m, 250, 751);
            SalesAndTaxes salesAndTaxes2 = new SalesAndTaxes(1002, 189.45m, 150, 852);
            SalesAndTaxes salesAndTaxes3 = new SalesAndTaxes(1003, 190.09m, 200, 803);
            SalesAndTaxes salesAndTaxes4 = new SalesAndTaxes(1004, 189.88m, 250, 754);
            SalesAndTaxes salesAndTaxes5 = new SalesAndTaxes(1005, 188.01m, 250, 755);
            SalesAndTaxes salesAndTaxes6 = new SalesAndTaxes(1006, 189.07m, 251, 755);
            SalesAndTaxes salesAndTaxes7 = new SalesAndTaxes(1007, 189.55m, 251, 756);


            CashOperations cashOperations1 = new CashOperations(200, 250, 200, 15);
            CashOperations cashOperations2 = new CashOperations(200, 150, 200, 11);
            CashOperations cashOperations3 = new CashOperations(200, 200, 200, 17);
            CashOperations cashOperations4 = new CashOperations(200, 250, 200, 22);
            CashOperations cashOperations5 = new CashOperations(200, 250, 200, 10);
            CashOperations cashOperations6 = new CashOperations(200, 251, 200, 15);
            CashOperations cashOperations7 = new CashOperations(200, 251, 200, 19);





            zReports.Add(new ZReport(1, reportInfo1, salesAndTaxes1, cashOperations1));
            zReports.Add(new ZReport(2, reportInfo2, salesAndTaxes2, cashOperations2));
            zReports.Add(new ZReport(3, reportInfo3, salesAndTaxes3, cashOperations3));
            zReports.Add(new ZReport(4, reportInfo4, salesAndTaxes4, cashOperations4));
            zReports.Add(new ZReport(5, reportInfo5, salesAndTaxes5, cashOperations5));
            zReports.Add(new ZReport(6, reportInfo6, salesAndTaxes6, cashOperations6));
            zReports.Add(new ZReport(7, reportInfo7, salesAndTaxes7, cashOperations7));
        }

        public List<ZReport> Retrieve()
        {
            return zReports;
        }
        public ZReport Retrieve(int number)
        {
            return zReports[number];
        }
    }
}
