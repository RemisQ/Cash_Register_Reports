using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cash_Register_Reports.Business
{
    public class ReportInfo
    {
        public int ReportMonth { get; }
        public int ReportDay { get; }
        public DateTime PrintedDate { get; }

        public ReportInfo(int reportMonth, int reportDay, DateTime printedDate)
        {
            ReportMonth = reportMonth;
            ReportDay = reportDay;
            PrintedDate = printedDate;
        }
    }
}
