using Cash_Register_Reports.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register_Reports.DataAccess
{
    public class XReportRepository
    {
        private List<XReport> xReport { get; }

        public XReportRepository()
        {
            xReport = new List<XReport>();
            int salesNow = Convert.ToInt32(DateTime.Now.Hour) * 100 + Convert.ToInt32(DateTime.Now.Minute);

            ReportInfo reportInfo = new ReportInfo((DateTime.Now.Month), (DateTime.Now.Day), DateTime.Now);
            SalesAndTaxes salesAndTaxes = new SalesAndTaxes(salesNow, Math.Round(salesNow * 0.21m, 2), Math.Round(salesNow * 0.25m, 2), Math.Round(salesNow * 0.75m, 2));
            CashOperations cashOperations = new CashOperations(200, -Math.Round(salesNow * 0.25m, 2), 200, Convert.ToInt32(DateTime.Now.Hour));
            XReport dayXReport = new XReport(reportInfo, salesAndTaxes, cashOperations);
            xReport.Add(dayXReport);

        }
        public List<XReport> Retrieve()
        {
            return xReport;
        }
        public XReport Retrieve(int number)
        {
            return xReport[number];
        }
    }
}
